using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.Forms
{
    public partial class SplashForm : Form
    {
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static SplashForm splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.
            if (splashForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(SplashForm.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Thread.Sleep(1000);
        }

        static private void ShowForm()
        {
            splashForm = new SplashForm();
            Inicialize();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(SplashForm.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
            splashForm = null;
        }


        static private void Inicialize()
        {
            splashForm.ClientSize = new System.Drawing.Size(360, 100);
            splashForm.Padding = new Padding(0,0,0,0);

            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Dock = DockStyle.Fill;
            splashForm.Controls.Add(panel);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = global::Tripper.Properties.Resources.Spinner;
            pictureBox.Size = new System.Drawing.Size(100, 100);
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Location = new System.Drawing.Point(0,0);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            panel.Controls.Add(pictureBox);
            panel.Padding = new Padding(10, 10, 10, 10);

            splashForm.StartPosition = FormStartPosition.CenterScreen;
            splashForm.FormBorderStyle = FormBorderStyle.None;

            Label labelHead = new Label();
            labelHead.Text = "Proszę czekać...";
            labelHead.BackColor = System.Drawing.Color.Transparent;
            labelHead.AutoSize = true;
            labelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelHead.ForeColor = System.Drawing.Color.DarkSlateGray;
            panel.Controls.Add(labelHead);
            labelHead.Location = new System.Drawing.Point(120, 30);

            Label labelInfo = new Label();
            labelInfo.Text = "Trwa ładowanie danych";
            labelInfo.BackColor = System.Drawing.Color.Transparent;
            labelInfo.AutoSize = true;
            labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            labelInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            panel.Controls.Add(labelInfo);
            labelInfo.Location = new System.Drawing.Point(120, 32 + labelHead.Height);

        }
    }
}
