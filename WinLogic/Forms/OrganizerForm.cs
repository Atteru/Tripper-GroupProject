using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.WinLogic.UserControls;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.BusinessLogic;
using System.Threading;

namespace Tripper.WinLogic.Forms
{
    public partial class OrganizerForm : Tripper.WinLogic.Forms.TripperDetailsViewPureForm
    {
        private Trip _selectedTrip;
        public Trip SelectedTrip
        {
            get
            {
                return _selectedTrip;
            }
            set
            {
                _selectedTrip = value;
            }
        }

        private NoteType _Type;
        private NoteType Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        private bool _createNewCheckBoxStatus;
        public bool CreateNewCheckBoxStatus
        {
            get
            {
                return _createNewCheckBoxStatus;
            }

            set
            {
                _createNewCheckBoxStatus = value;
                bAddNewNote.Visible = !value;
                pCreateNewCheckBox.Visible = value;
                pRadioButtons.Visible = value;

                if (!value)
                {
                    tNewTitle.Text = string.Empty;
                    tNewTitle.Label.Visible = true;
                    rbNote.Checked = true;
                }
            }
        }

        List<ToDoList> ToDoCheckList = new List<ToDoList>();
        List<CheckBoxUC> CheckBoxControlList = new List<CheckBoxUC>();

        List<Note> NoteList = new List<Note>();
        List<NoteHeaderUC> NoteControList = new List<NoteHeaderUC>();


        public OrganizerForm(Trip selectedTrip)
        {
            InitializeComponent();
            SelectedTrip = selectedTrip;
            loadNotesList();
            loadChcekList();
            Type = NoteType.Note;
        }

        private void loadChcekList()
        {
            if (ToDoCheckList.Count > 0)
            {
                ToDoCheckList.Clear();
                foreach (CheckBoxUC row in CheckBoxControlList)
                    row.Visible = false;
                CheckBoxControlList.Clear();
            }

            ToDoCheckList = Connection.TripperData.ToDoLists.Where(toDo => toDo.TripID == SelectedTrip.TripID).ToList();
            ToDoCheckList = ToDoCheckList.OrderBy(toDO => toDO.ToDoListID).ToList();

            foreach (ToDoList row in ToDoCheckList)
            {
                CheckBoxUC checkBox = new CheckBoxUC(row);
                addNoteToList(ToDoCheckList, CheckBoxControlList, row, checkBox);
            }
        }

        private void loadNotesList()
        {
            if (NoteList.Count > 0)
            {
                NoteList.Clear();
                foreach (NoteHeaderUC row in NoteControList)
                    row.Visible = false;
                NoteControList.Clear();
            }

            NoteList = Connection.TripperData.Notes.Where(toDo => toDo.TripID == SelectedTrip.TripID).ToList();
            NoteList = NoteList.OrderBy(toDO => toDO.NoteID).ToList();

            foreach (Note row in NoteList)
            {
                NoteHeaderUC noteControl = new NoteHeaderUC(row);
                addNoteToList(NoteList, NoteControList, row, noteControl);
            }
        }


        private void addNoteToList<T, T2>(List<T> noteList, List<T2> controlList, T note, Control control, bool crateNewMode = false)
        {
            if(crateNewMode)
              noteList.Add(note);

            pOrganizerCenter.Controls.Add(control);
            control.Dock = DockStyle.Top;
        }


        private void bCancel_Click(object sender, EventArgs e)
        {
            CreateNewCheckBoxStatus = false;
        }

        private void bAddNewChBox_Click(object sender, EventArgs e)
        {
            CreateNewCheckBoxStatus = true;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tNewTitle.CheckValidation())
            {
                Control note;
                
                if (Type == NoteType.CheckBox)
                {
                    ToDoList newToDoCheckBox = new ToDoList();
                    newToDoCheckBox.Text = tNewTitle.Text;
                    newToDoCheckBox.TripID = SelectedTrip.TripID;
                    newToDoCheckBox.IsChecked = false;
                    note = new CheckBoxUC(newToDoCheckBox);
                    Connection.TripperData.ToDoLists.InsertOnSubmit(newToDoCheckBox);
                    note.BackColor = SystemColors.Control;

                    if (submitChanges())
                        addNoteToList(ToDoCheckList, CheckBoxControlList, newToDoCheckBox, note, true);

                }
                else if (Type == NoteType.Note)
                {
                    Note newNote = new Note();
                    newNote.Title = tNewTitle.Text;
                    newNote.TripID = SelectedTrip.TripID;
                    newNote.NoteText = string.Empty;
                    note = new NoteHeaderUC(newNote);
                    Connection.TripperData.Notes.InsertOnSubmit(newNote);
                    note.BackColor = SystemColors.Control;

                    if (submitChanges())
                        addNoteToList(NoteList, NoteControList, newNote, note, true);

                    NoteForm noteForm = new NoteForm(newNote);
                    noteForm.ShowDialog();
                }
            }
        }

        private bool submitChanges()
        {
            DialogResult dialogResult = TripperMessageBox.Show("Dodać nową notatkę", "");
            bool operationResult = true;

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Connection.TripperData.SubmitChanges();

                }
                catch (Exception exept)
                {
                    TripperMessageBox.Show(exept.ToString(), "Błąd");
                    operationResult = false;
                }
                finally
                {
                    CreateNewCheckBoxStatus = false;
                }
                return operationResult;
            }
            return false;
        }


        private void rbNote_CheckedChanged(object sender, EventArgs e)
        {
            Type = NoteType.Note;
        }

        private void rbCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Type = NoteType.CheckBox;
        }
    }
}
