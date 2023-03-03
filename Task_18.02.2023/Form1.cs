using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_18._02._2023
{
    public partial class HotelWebsite : Form
    {
        static List<Guest> reservedGuests = new List<Guest>() 
        {new Guest("Саитов М.А.", new DateTime(2004, 5, 2), "Зарезервировано", new DateTime(2023, 2, 23), new DateTime(2023, 3, 12)), 
            new Guest("Ноунеймов К.В.", new DateTime(2003, 2, 12), "Зарезервировано", new DateTime(2023, 4, 1), new DateTime(2023, 5, 22)) };
        static List<Guest> freeGuests = new List<Guest>()
        {new Guest("Паморин М.А.", new DateTime(2004, 1, 1), "Свободные", new DateTime(2023, 2, 23), new DateTime(2023, 3, 12)),
            new Guest("Печькин К.В.", new DateTime(2004, 2, 16), "Свободные", new DateTime(2023, 4, 1), new DateTime(2023, 5, 22)) };
        static List<Guest> occupiedGuests = new List<Guest>()
        {new Guest("Абдрухманов М.А.", new DateTime(2004, 3, 21), "Заняты", new DateTime(2023, 2, 23), new DateTime(2023, 3, 12)),
            new Guest("Игнатов К.В.", new DateTime(2004, 4, 14), "Заняты", new DateTime(2023, 4, 1), new DateTime(2023, 5, 22)) };
        static List<Guest> dischargedGuests = new List<Guest>()
        {new Guest("Кокорин М.А.", new DateTime(2004, 9, 6), "Выписываются", new DateTime(2023, 2, 23), new DateTime(2023, 3, 12)),
            new Guest("Хайнутдинов К.В.", new DateTime(2004, 12, 19), "Выписываются", new DateTime(2023, 4, 1), new DateTime(2023, 5, 22)) };

        static List<Guest> temp = new List<Guest>();
        public HotelWebsite()
        {
            InitializeComponent();

            label5.Text = DateTime.Now.ToString();
            StatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void ReservedClick(object Sender, EventArgs e)
        {
            temp = reservedGuests;
            guestsBox.Items.Clear();
            foreach (Guest man in reservedGuests)
            {
                guestsBox.Items.Add(man.GetFio());
            }
            
        }
        public void FreeClick(object Sender, EventArgs e)
        {
            temp = freeGuests;
            guestsBox.Items.Clear();
            foreach (Guest man in freeGuests)
            {
                guestsBox.Items.Add(man.GetFio());
            }

        }
        public void OccupiedClick(object Sender, EventArgs e)
        {
            temp = occupiedGuests;
            guestsBox.Items.Clear();
            foreach (Guest man in occupiedGuests)
            {
                guestsBox.Items.Add(man.GetFio());
            }
        }
        private void DischargeClick(object sender, EventArgs e)
        {
            temp = dischargedGuests;
            guestsBox.Items.Clear();
            foreach (Guest man in dischargedGuests)
            {
                guestsBox.Items.Add(man.GetFio());
            }
        }
        public void GuestBoxDoubleClick(object sender, EventArgs e)
        {
            guestInfoBox.Text = guestsBox.SelectedItem.ToString();
            foreach (Guest man in temp)
            {
                if (guestsBox.SelectedItem.ToString() == man.GetFio())
                {
                    StatusBox.Text = man.GetStatus();
                    checkInDateLabel.Text = man.GetCheckInDate();
                    checkOutDateLabel.Text = man.GetCheckOutDate();
                    popUpWindowButton.Enabled = true;
                    resetAndSetSelectedStatusBox(man.GetStatus());
                    break;
                }
            }
        }

        private void resetAndSetSelectedStatusBox(string str)
        {
            StatusBox.Items.Clear();
            StatusBox.Items.Add("Зарезервировано");
            StatusBox.Items.Add("Выписываются");
            StatusBox.Items.Add("Заняты");
            StatusBox.Items.Add("Свободные");
            StatusBox.SelectedItem = str;
        }
        private void SearchClick(object sender, MouseEventArgs e)
        {
            searchBox.Text = "";
        }


        #region *Exit Button*
        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitMouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(98, 14, 24);
        }

        private void ExitMouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.Red;
        }
        #endregion


        #region *Window's Moving*
        Point lastPoint;
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void PopUpWindowButtonCLick(object sender, EventArgs e)
        {
            Form2 popUpWindow = new Form2();
            if (reservedButton.Checked)
            {
                foreach(Guest man in reservedGuests)
                {
                    if(man.GetFio() == guestsBox.SelectedItem.ToString())
                    {
                        popUpWindow.SetGuest(man);
                        break;
                    }
                }
            }
            else if (freeButton.Checked)
            {
                foreach(Guest man in freeGuests)
                {
                    if (man.GetFio() == guestsBox.SelectedItem.ToString())
                    {
                        popUpWindow.SetGuest(man);
                        break;
                    }
                }
            }
            else if (occupiedButton.Checked)
            {
                foreach(Guest man in occupiedGuests)
                {
                    if (man.GetFio() == guestsBox.SelectedItem.ToString())
                    {
                        popUpWindow.SetGuest(man);
                        break;
                    }
                }
            }
            else if (dischargedButton.Checked)
            {
                foreach(Guest man in dischargedGuests)
                {
                    if (man.GetFio() == guestsBox.SelectedItem.ToString())
                    {
                        popUpWindow.SetGuest(man);
                        break;
                    }
                }
            }
            popUpWindow.ShowDialog();
        }
    }
}
