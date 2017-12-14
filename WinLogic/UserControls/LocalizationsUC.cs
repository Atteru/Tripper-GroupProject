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

        private Country _selectedCoutry;
        public Country SelectedCoutry
        {
            get
            {
                return _selectedCoutry;
            }
            private set
            {
                _selectedCoutry = value;
            }
        }

        private bool inicialized = false;

        public LocalizationsUC()
        {
            InitializeComponent();
            cbCountry.DataSource = CountryList;
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

        public void FillLocalizationFields(int? localizationID)
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


        public List<Country> CountryList { get => countryList; set => countryList = value; }

        private void cbCountry_TextUpdate(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            var list = CountryList.Where(country => country.Name.StartsWith(comboBox.Text, true, ci));
            newRefresh<Country>(comboBox, list);
        }

        private void loadCoutryList(out List<Country> list)
        {
            list = Connection.TripperData.Countries.ToList();
            setStartingCoutrySource();

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

            SelectedLocalization = null;
            cbCity.Text = "";
            
              cbCountry_Validating(sender, null);
            if(SelectedLocalization == null)
                cbCity.SelectedIndex = -1;

        }

        private void addNewCity()
        {
            var list = cbCity.DataSource as List<Localization>;
            if (list != null)
            {
                bool ifCityExist = list.Any(city => city.City.Equals(cbCity.Text, StringComparison.Ordinal));
                if (!ifCityExist && cbCity.Text != string.Empty)
                {
                    DialogResult result = TripperMessageBox.Show("Podanego miasta nie ma na liście.\nCzy chcesz je dodać?", "Czy chcesz dodać miasto? ");
                    if (result == DialogResult.Yes)
                    {
                        Localization newCity = new Localization();
                        newCity.Country = cbCountry.SelectedItem as Country;
                        newCity.City = cbCity.Text;
                        Connection.TripperData.Localizations.InsertOnSubmit(newCity);
                        try
                        {
                            Connection.TripperData.SubmitChanges();
                            cityList = Connection.TripperData.Localizations.Where(city => city.Country.Equals(cbCountry.SelectedItem) && city.Equals(newCity)).ToList();
                            cbCity.DataSource = cityList;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        cbCity.Text = string.Empty;
                        cbCity.SendToBack();
                    }
                    //cbCity_Validating(cbCity, null);
                    cbCity.Close();
                }
            }
        }

        private void cbCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            addNewCity();
        }

        private void cbCountry_Leave(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            //cbCountry_SelectionChangeCommitted(comboBox, null); 
            comboBox.Close(); 
        }

        private void cbCity_Leave(object sender, EventArgs e)
        {
            DynamicCombo comboBox = sender as DynamicCombo;
            cbCity_SelectionChangeCommitted(comboBox, null);
            comboBox.Close();
        }

        private bool checkCountryValidation()
        {

            if(countryList == null)
                loadCoutryList(out countryList);

            bool validationResult;

            if (cbCountry.Text == string.Empty)
            {
                lCountryError.Visible = true;
                lCountryError.Text = CountryMessageIfEmpty;
                lCountryError.BringToFront();
                validationResult = false;
            }
            else if (!CountryList.Any(country => country.Name.Equals(cbCountry.Text)))
            {
                cbCountry.SelectedItem = cbCountry.Text = null;
                lCountryError.Visible = true;
                lCountryError.Text = "Nieprawidłowa wartość";
                lCountryError.BringToFront();
                validationResult = false;
            }
            else
            {
                if (!lCountryError.Visible)
                    lCountryError.Visible = false;
                validationResult = true;
            }

            return validationResult;
        }

        private bool checkCityValidation()
        {
            SelectedLocalization = null;
            bool validationResult;
            if (cbCity.Text == string.Empty)
            {
                lCityError.Visible = true;
                lCityError.Text = CityMessageIfEmpty;
                lCityError.BringToFront();
                validationResult = false;
            }
            else
            {
                if (SelectedLocalization != cbCity.SelectedItem as Localization)
                    SelectedLocalization = cbCity.SelectedItem as Localization;
                lCityError.Visible = false;
                validationResult = true;
            }
            return validationResult;
        }


        private void cbCountry_Validating(object sender, CancelEventArgs e)
        {
            checkCountryValidation();
        }

        private void cbCity_Validating(object sender, CancelEventArgs e)
        {
            checkCityValidation();
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
            this.Refresh();
        }

        private void cbCity_Click(object sender, EventArgs e)
        {
            if (lCityError.Visible)
                lCityError.Visible = false;
            this.Refresh();
        }

        private void setStartingCoutrySource()
        {
            if (cbCountry.Text == string.Empty)
            {
                cbCountry.DataSource = countryList.ToList();
                cbCountry.SelectedIndex = -1;
            }
            else
            {
                cbCountry.DataSource = countryList.Where(country => country.Name.Equals(cbCountry.Text)).ToList();
                 
            }
        }


        public void drawWarningBoeder(object sender)
        {
            DynamicCombo comboBox = sender as DynamicCombo;

            Graphics g = this.CreateGraphics();
            
            Pen blackPen = new Pen(Color.Firebrick, 4);
            int x = comboBox.Location.X;
            int y = comboBox.Location.Y;
            int width = comboBox.Width;
            int height = comboBox.Height;

            g.DrawRectangle(blackPen, x, y, width, height);
            blackPen.Dispose();
        }


        public bool CheckValidation()
        {
            bool validationResult = true;

            if (!checkCountryValidation())
            {
                drawWarningBoeder(cbCountry);
                validationResult = false;
            }

            if (!checkCityValidation())
            {
               drawWarningBoeder(cbCity);
                validationResult = false;
            }

            return validationResult;
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lCountryError.Visible)
                lCountryError.Visible = false;
            SelectedCoutry = cbCountry.SelectedItem as Country;
        }

        private void cbCountry_Enter(object sender, EventArgs e)
        {
            if (inicialized == false)
            {
                loadCoutryList(out countryList);
                inicialized = true;
            }
        }

    }
}
