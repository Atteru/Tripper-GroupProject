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
using System.Globalization;
using Tripper.WinLogic.Forms;

namespace Tripper.WinLogic.UserControls
{
    public partial class LocalizationsUC : UserControl
    {
        List<Country> countryList;
        List<Localization> cityList;
        CultureInfo ci = new CultureInfo("en-US");


        public string CityMessageIfEmpty
        {
            get; set;
        }

        public string CountryMessageIfEmpty
        {
            get; set;
        }

        [Browsable(true)]
        public bool MessageVisibility
        {
            get
            {
                return lCityError.Visible == true && lCountryError.Visible == true;
            }
            set
            {
                lCountryError.Visible = lCityError.Visible = value;
            }
        }

        private Localization _selectedLocalization;
        public Localization SelectedLocalization
        {
            get
            {
                return _selectedLocalization;
            }
            set
            {
                _selectedLocalization = value;
            }
        }

        public LocalizationsUC()
        {
            InitializeComponent();
            cbCountry.DataSource = countryList;
            cbCountry.SelectedIndex = -1;
            cbCountry.IsOpened = false;
            cbCity.IsOpened = false;
            lCityError.Text = CityMessageIfEmpty = "Miasto";
            lCountryError.Text = CountryMessageIfEmpty = "Kraj";
        }

        public DynamicCombo CountryBox
        {
            get
            {
                return cbCountry;
            }
        }

        public DynamicCombo CityBox
        {
            get
            {
                return cbCity;
            }
        }

        public void FillLocalizationFields(int localizationID)
        {
            MessageVisibility = false;
            cbCity.DataSource = Connection.TripperData.Localizations.Where(local => local.LocalizationID == localizationID);
            cbCountry.DataSource = Connection.TripperData.Countries.Where(coutry => coutry.CountryID == ((Localization)cbCity.SelectedItem).CountryID);
        }

        public int GetLocalizationFromFields()
        {
            Localization selectedLocalization = cbCity.SelectedItem as Localization;
            return selectedLocalization.LocalizationID;
        }


        private void cbCountry_TextUpdate(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            var list = countryList.Where(country => country.Name.StartsWith(comboBox.Text, true, ci));
            newRefresh<Country>(comboBox, list);
        }

        public void newRefresh<T>(DynamicCombo comboBox, IEnumerable<T> list)
        {
            var tempList = list.Select(item => item).ToList();

            if (tempList.Count > 0)
            {
                string tempString = comboBox.Text;
                comboBox.DataSource = tempList;
                comboBox.SelectedIndex = -1;
                comboBox.Text = tempString;

                int listLength;
                if (comboBox.Items.Count > 10)
                    listLength = 10;
                else
                    listLength = comboBox.Items.Count;

                comboBox.Height = comboBox.ItemHeight * listLength + comboBox.ItemHeight * 2;

                Cursor.Current = DefaultCursor;
            }
            else
            {
                comboBox.DataSource = tempList;
                comboBox.Close();
            }
            comboBox.SelectionStart = comboBox.Text.Length + 1;
        }

        private void cbCity_TextUpdate(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            cityList = Connection.TripperData.Localizations.Where(city => city.Country.Equals(cbCountry.SelectedItem)).ToList();
            var citesByCountry = cityList.Where(city => city.City.StartsWith(comboBox.Text, true, ci)).ToList();
            newRefresh<Localization>(comboBox, citesByCountry);
        }

        private void cbCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            cityList = Connection.TripperData.Localizations.Where(city => city.Country.Equals(cbCountry.SelectedItem)).ToList();
            cbCity.DataSource = cityList;
            if (cbCity.Items.Count == 0)
            {
                cbCity.Text = "";
            }
            //  cbCountry_Validating(sender, null);
            cbCity.SelectedIndex = -1;
            
        }

        private void cbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            DynamicCombo comboBox = sender as DynamicCombo;
            var list = comboBox.DataSource as List<Localization>;
            if (list != null)
            {
                bool ifCityExist = list.Any(city => city.City.Equals(comboBox.Text, StringComparison.Ordinal));
                if (!ifCityExist && comboBox.Text != string.Empty)
                {
                    DialogResult result = TripperMessageBox.Show("Podanego miasta nie ma na liście.\nCzy chcesz je dodać?", "Czy chcesz dodać miasto? ");
                    if (result == DialogResult.Yes)
                    {
                        Localization newCity = new Localization();
                        newCity.Country = cbCountry.SelectedItem as Country;
                        newCity.City = comboBox.Text;
                        Connection.TripperData.Localizations.InsertOnSubmit(newCity);
                        try
                        {
                            Connection.TripperData.SubmitChanges();
                            cityList = Connection.TripperData.Localizations.Where(city => city.Country.Equals(cbCountry.SelectedItem) && city.Equals(newCity)).ToList();
                            comboBox.DataSource = cityList;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                  //  cbCity_Validating(sender, null);
                    comboBox.Close();
                }
            }
        }

        private void cbCountry_Leave(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            cbCountry_SelectionChangeCommitted(comboBox, null);
            comboBox.Close(); 
        }

        private void cbCity_Leave(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            comboBox.Close();
        }

        private void cbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cbCountry.Text == string.Empty)
            {
                lCountryError.Visible = true;
                lCountryError.Text = CountryMessageIfEmpty;
                lCountryError.BringToFront();
            }
            else if (!countryList.Any(country => country.Name.Equals(cbCountry.Text)))
            {
                cbCountry.SelectedItem = cbCountry.Text = null;
                lCountryError.Visible = true;
                lCountryError.Text = "Nieprawidłowa wartość";
                lCountryError.BringToFront();
            }
            else
            {
                if(!lCountryError.Visible)
                    lCountryError.Visible = false;
            }
        }

        private void cbCity_Validating(object sender, CancelEventArgs e)
        {
            SelectedLocalization = null;
            if (cbCity.Text == string.Empty)
            {
                lCityError.Visible = true;
                lCityError.Text = CityMessageIfEmpty;
                lCityError.BringToFront();
            }
            else
            {
                if (SelectedLocalization != cbCity.SelectedItem as Localization)
                    SelectedLocalization = cbCity.SelectedItem as Localization;
                lCityError.Visible = false;
            }
        }

        private void lCountryError_Click(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            cbCountry.Focus();
            cbCountry.ClickEvent();
        }

        private void lCityError_Click(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            cbCity.Focus();
            cbCity.ClickEvent();
        }

        private void cbCountry_Click(object sender, EventArgs e)
        {
            if (lCountryError.Visible)
                lCountryError.Visible = false;
        }

        private void cbCity_Click(object sender, EventArgs e)
        {
            if (lCityError.Visible)
                lCityError.Visible = false;
        }

        private void cbCountry_Enter(object sender, EventArgs e)
        {
            if (countryList == null)
                countryList = Connection.TripperData.Countries.ToList();
        }
    }
}
