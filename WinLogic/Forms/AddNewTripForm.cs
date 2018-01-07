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
using Tripper.BusinessLogic;
using System.Threading;
using Tripper.WinLogic.Classes;

namespace Tripper.WinLogic.Forms
{
    public partial class AddNewTripForm : TripperDetailsEditPureForm
    {
        public event EventHandler AfterAdd;

        private Trip _selectedTrip;
        public Trip SelectedTrip
        {
            get
            {
                return _selectedTrip;
            }
            private set
            {
                _selectedTrip = value;
            }
        }

        private Traveler _selectedTraveler;
        public Traveler SelectedTraveler
        {
            get
            {
                return _selectedTraveler;
            }
            private set
            {
                _selectedTraveler = value;
            }
        }

        private int _selectedAvatar;
        public int SelectedAvatar
        {
            get
            {
                return _selectedAvatar;
            }
            set
            {
                _selectedAvatar = value;
                pcCurrentAvatar.BackgroundImage = imageAvatarList.Images[value];
                pcCurrentAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public AddNewTripForm(Traveler traveler)
        {
            Mode = CreatorMode.AddNew;
            InitializeComponent();
            addAvatarList(imageAvatarList);
            SelectedTraveler = traveler;
            SelectedAvatar = 0;
            bAdd.Text = "Dodaj";
        }

        public AddNewTripForm(Trip trip)
        {
            Mode = CreatorMode.Edit;
            InitializeComponent();
            SelectedTrip = trip;
            tTitle.Text = SelectedTrip.Name;
            SelectedAvatar = SelectedTrip.ImageIndex;
            addAvatarList(imageAvatarList);
            bAdd.Text = "Zapisz";

        }

        private bool readyToClose = false;

        private void setButtonStyle(Button button)
        {
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            button.Location = new System.Drawing.Point(5, 0);
            button.Text = string.Empty;
            button.Size = new System.Drawing.Size(120, 90);
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
        }

        private void addAvatarList (ImageList imageList)
        {
            for(int i = 0; i < imageList.Images.Count; i++ )
            {
                Button button = new Button();
                setButtonStyle(button);
                button.BackgroundImage = imageAvatarList.Images[i];
                pcCurrentAvatar.BackgroundImageLayout = ImageLayout.Stretch;
                button.Tag = i;
                pAvatar.Controls.Add(button);
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SelectedAvatar = (int)button.Tag;
        }

        private void AddNewTripForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!readyToClose)
            {
                DialogResult result = TripperMessageBox.Show("Czy czcesz wyjść bez zapisana zmian?", "Czy napewno?");
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tTitle.CheckValidation())
            {
                if (Mode == CreatorMode.AddNew)
                {
                    Trip newTrip = new Trip();
                    newTrip.Name = tTitle.Text;
                    newTrip.ImageIndex = SelectedAvatar;
                    newTrip.TravelerID = SelectedTraveler.TravelerID;
                    Connection.TripperData.Trips.InsertOnSubmit(newTrip);

                    try
                    {
                        Connection.TripperData.SubmitChanges();
                        CurrentSelected.Trip = newTrip;
                        OnAfterAdd(EventArgs.Empty);
                        readyToClose = true;
                        this.Close();
                    }
                    catch (Exception exept)
                    {
                        TripperMessageBox.Show(exept.ToString(), "Błąd");
                    }
                }
                else
                {
                    SelectedTrip.Name = tTitle.Text;
                    SelectedTrip.ImageIndex = SelectedAvatar;

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

        protected virtual void OnAfterAdd(EventArgs e)
        {
            EventHandler handler = AfterAdd;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
