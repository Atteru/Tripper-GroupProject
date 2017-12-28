using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.DbLogic.LinqToSQL;
using Tripper.DbLogic;
using System.Globalization;
using Tripper.WinLogic.Forms;

namespace Tripper.WinLogic
{
    public partial class DropDownListUC : UserControl
    {

        public object DataSource
        {
            get
            {
                return dropDownList.DataSource;
            }
            set
            {
                dropDownList.DataSource = value;
            }
        }

        private bool _listBoxVilibility;
        private bool ListBoxVilibility
        {
            get
            {
                return _listBoxVilibility;
            }
            set
            {
                if (_listBoxVilibility != value)
                {
                    _listBoxVilibility = value;
                    dropDownList.Visible = value;
                }
            }
        }

        private object _selectedItem;
        public object SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if(_selectedItem != value)
                {
                    if (SelectedItem == null)
                        dropDownHeader.ForeColor = SystemColors.WindowText;

                    _selectedItem = value;
                    Text = SelectedItem.ToString();
                }
            }
        }

        public override string Text
        {
            get
            {
               return dropDownHeader.Text;
            }
            set
            {
                dropDownHeader.Text = value;

            }
        }

        private bool inicialized = false;

        public DropDownListUC()
        {
            InitializeComponent();
            ListBoxVilibility = false;
            dropDownHeader.Text = "Wybierz";
            dropDownHeader.ForeColor = SystemColors.ButtonShadow;
        }

        private void dropDownHeader_Click(object sender, EventArgs e)
        {
            ListBoxVilibility = !ListBoxVilibility;
            Focus();
        }

        private void DropDownListUC_Leave(object sender, EventArgs e)
        {
            ListBoxVilibility = false;
        }

        private void DropDownListUC_Enter(object sender, EventArgs e)
        {
            if (inicialized == false)
            {
                dropDownList.Height = dropDownList.ItemHeight * dropDownList.Items.Count;
                dropDownList.ClearSelected();
                inicialized = true;
            }
        }

        private void dropDownList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (inicialized)
            {
                SelectedItem = dropDownList.SelectedItem;
                ListBoxVilibility = false;
            }


        }
    }
}
