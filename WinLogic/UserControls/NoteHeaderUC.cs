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
using Tripper.WinLogic.Forms;

namespace Tripper.WinLogic.UserControls
{
    public partial class NoteHeaderUC : UserControl
    {
        private Note _selectedNote;
        public Note SelectedNote
        {
            get
            {
                return _selectedNote;
            }
            private set
            {
                _selectedNote = value;
            }
        }

        public NoteHeaderUC(Note selectedNote)
        {
            InitializeComponent();
            SelectedNote = selectedNote;
            lTitle.Text = SelectedNote.Title;
        }


        private void lTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NoteForm note = new NoteForm(SelectedNote);
            note.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = TripperMessageBox.Show("Czy napewno usunąć?", "Czy napewno?");
            if (result == DialogResult.Yes)
            {
                Connection.TripperData.Notes.DeleteOnSubmit(SelectedNote);

                try
                {
                    this.Visible = false;
                    Connection.TripperData.SubmitChanges();
                }
                catch (Exception exept)
                {
                    TripperMessageBox.Show(exept.ToString(), "Błąd");
                }

            }
        }
    }
} 
    
