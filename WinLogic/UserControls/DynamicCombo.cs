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

namespace Tripper.WinLogic.UserControls
{
    public partial class DynamicCombo : ComboBox
    {
        public DynamicCombo()
        {
            //InitializeComponent();
            this.IsOpened = false;
            this.PreviewKeyDown += DynamicCombo_PreviewKeyDown;
            this.Resize += DynamicCombo_SizeChanged;
            this.Click += DynamicCombo_Click;
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DataSourceChanged += DynamicCombo_DataSourceChanged;
        }

        private Color _borderColor = SystemColors.WindowFrame;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;

        
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if(!this.Focused && this.Enabled)
                if (m.Msg == WM_PAINT)
                {
                    Graphics g = Graphics.FromHwnd(Handle);
                    Rectangle bounds = new Rectangle(0, 0, Width, Height);
                    ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
                }
        } 

        public int StartingSize
        {
            get; set;
        }

        public bool IsOpened
        {
            get; set;
        }

        public void drawWarningBoeder()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            Pen blackPen = new Pen(Color.Black, 4);

            int x = this.Location.X;
            int y = this.Location.Y;
            int width = this.Width;
            int height = this.Height;

            g.DrawRectangle(blackPen, x, y, width, height);
            blackPen.Dispose();
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

        public void ClickEvent()
        {
            this.DynamicCombo_Click(this, null);
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
            if (StartingSize > 0)
                this.Height = StartingSize;
        }

        private void DynamicCombo_DataSourceChanged(object sender, EventArgs e)
        {
        var comboBox = sender as DynamicCombo;

            if (comboBox.Height > comboBox.StartingSize && StartingSize != 0)
                comboBox.IsOpened = true;
            else
                comboBox.IsOpened = false;
        }
      

    }
}
