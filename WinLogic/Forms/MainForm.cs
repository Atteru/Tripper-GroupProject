using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripper.WinLogic.Forms
{
    public partial class MainForm : Form
    {
        TripDetailsView tripDetails;
        Form currentUseForm;

        public int UserID
        {
            get;
            private set;
        }


        /*  public MainForm(int userId)
          {
              InitializeComponent();
              UserID = userId;

          }*/

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            OpenTripDetalis();
        }


        private void OpenTripDetalis()
        {
            tripDetails = new TripDetailsView();
            tripDetails.TopLevel = false;
            tripDetails.Parent = pCenter;
            tripDetails.Dock = DockStyle.Fill;
            tripDetails.Show();
        }

        private void bTransport_Click(object sender, EventArgs e)
        {
            if (tripDetails.DisplayedForm != null)
            {
                tripDetails.DisplayedForm.Close();
            }
            
                tripDetails.ShowTransportDetails();
        }

        private void bStayment_Click(object sender, EventArgs e)
        {
            if (tripDetails.DisplayedForm != null)
            {
                tripDetails.DisplayedForm.Close();
            }
               
        }
    }
}
