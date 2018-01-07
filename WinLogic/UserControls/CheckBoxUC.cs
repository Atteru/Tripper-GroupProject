using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic.LinqToSQL;
using Tripper.DbLogic;
using Tripper.WinLogic.Forms;

namespace Tripper.WinLogic.UserControls
{
    public partial class CheckBoxUC : UserControl
    {
        private ToDoList _toDoCheckBox;
        public ToDoList ToDoCheckBox
        {
            get
            {
                return _toDoCheckBox;
            }
            private set
            {
                _toDoCheckBox = value;
            }
        }

        public CheckBoxUC(ToDoList toDoList)
        {
            InitializeComponent();
            ToDoCheckBox = toDoList;
            setCheckBox(ToDoCheckBox);
        }

        private void setCheckBox(ToDoList toDoList)
        {
            checkBox.Text = toDoList.Text;
            checkBox.Checked = toDoList.IsChecked;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            bool currentState = !checkBox.Checked;
            ToDoCheckBox.IsChecked = checkBox.Checked;

            try
            {
                Connection.TripperData.SubmitChanges();
            }
            catch (Exception exept)
            {
                TripperMessageBox.Show(exept.ToString(), "Błąd");
                checkBox.Checked = currentState;
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = TripperMessageBox.Show("Czy napewno usunąć?", "Czy napewno?");
            if (result == DialogResult.Yes)
            {
                Connection.TripperData.ToDoLists.DeleteOnSubmit(ToDoCheckBox);

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
