using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tripper.DbLogic;
using Tripper.DbLogic.LinqToSQL;
using Tripper.WinLogic.UserControls;
using Tripper.WinLogic.Classes;
using System.Globalization;
using Tripper.Enums;


namespace Tripper.WinLogic.Forms
{
    public partial class NewTransportCreator : Form
    {
        List<Country> countryList = Connection.TripperData.Countries.ToList();
        List<Localization> cityList = Connection.TripperData.Localizations.ToList();
        NewTransport newTransport = new NewTransport();
        CultureInfo ci = new CultureInfo("en-US");
        Vehicle type;


        public NewTransportCreator(object vehicle)
        {
            InitializeComponent();
            type = (Vehicle)vehicle;
            //textBoxUC1.Font = new Font("Microsoft Sans Serif", 12);
            //textBoxUC2.Font = new Font("Microsoft Sans Serif", 12);
            //textBoxUC3.Font = new Font("Microsoft Sans Serif", 12);

        }

        private void NewTransportCreator_Load(object sender, EventArgs e)
        {

            switch (type)
            {
                case Vehicle.Samolot:
                    //lOthers1.Text = "Nr. Lotu";
                 //   lOthers2.Text = "Terminal";
                    break;
                case Vehicle.Pociąg:
                  //  lOthers1.Text = "Peron";
                  //  lOthers2.Text = "Nr. Wagonu";
                    break;
                case Vehicle.Samochód:
                    break;
                case Vehicle.Bus:
                    break;

            }
        }
    }
}
