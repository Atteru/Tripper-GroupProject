using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tripper.WinLogic.UserControls
{
    public class DynamicCombo : ComboBox
    {
        public int StartingSize
        {
            get; set;
        }

        public bool IsOpened
        {
            get; set;
        }

        private bool initialized = false;

        public DynamicCombo()
            :base()
        {
            this.IsOpened = false;
            this.PreviewKeyDown += DynamicCombo_PreviewKeyDown;
            this.Resize += DynamicCombo_SizeChanged;
            this.Click += DynamicCombo_Click; 
        }

        private void DynamicCombo_Click(object sender, System.EventArgs e)
        {
            var comboBox = sender as DynamicCombo;
            comboBox.BringToFront();
            if (comboBox.StartingSize == 0)
                comboBox.StartingSize = comboBox.Height;

            if (!comboBox.IsOpened)
            {
                if (comboBox.Items.Count > 0)
                {
                    int listLength;
                    if (comboBox.Items.Count > 10)
                        listLength = 10;
                    else
                        listLength = comboBox.Items.Count;

                    comboBox.Height = comboBox.ItemHeight * listLength + comboBox.ItemHeight * 2;
                }
            }
            else
            {
                if (comboBox.SelectedItem != null)
                {
                    List<object> tempList = new List<object>();
                    tempList.Add(comboBox.SelectedItem);
                    comboBox.DataSource = tempList;
                }

                comboBox.Close();
            }
        }

        private void DynamicCombo_SizeChanged(object sender, System.EventArgs e)
        {
            var comboBox = sender as DynamicCombo;
            
            if (comboBox.Height > comboBox.StartingSize && StartingSize != 0)
                comboBox.IsOpened = true;
            else
                comboBox.IsOpened = false;
        }

        private void DynamicCombo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var comboBox = sender as DynamicCombo;
            if (e.KeyCode == Keys.Enter)
            {
                comboBox.Close();
            }
        }

        public void Close()
        {
            if(StartingSize > 0)
                this.Height = StartingSize;
            this.SendToBack();
        }
    }
}
