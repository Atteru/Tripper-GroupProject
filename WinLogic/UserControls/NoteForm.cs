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
    public partial class NoteForm : TripperDetailsEditPureForm
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

        public NoteForm( )
        {
            InitializeComponent();

        }

       public NoteForm(Note selectedNote)
       {
           InitializeComponent();
           SelectedNote = selectedNote;
           lTitle.Text = selectedNote.Title;
           richTextBox.Text = selectedNote.NoteText;
       }

        bool readyToClose = false;

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!readyToClose)
            {
                DialogResult result = TripperMessageBox.Show("Czy czcesz wyjść bez zapisana zmian?", "Czy napewno?");
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            SelectedNote.NoteText = richTextBox.Text;

            try
            {
                Connection.TripperData.SubmitChanges();
                readyToClose = true;
                this.Close();
            }
            catch (Exception exept)
            {
                TripperMessageBox.Show(exept.ToString(), "Błąd");
                
            }
        }
    }   
}
