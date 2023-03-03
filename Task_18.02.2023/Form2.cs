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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            paymentBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void SetGuest(Guest guest)
        {
            userNameLabel.Text = guest.GetFio();
            dateOfBirthLabel.Text = guest.GetDateOfBirth();
        }

        private void resetAndSetSelectedStatusBox()
        {
            paymentBox.Items.Clear();
            paymentBox.Items.Add("Тинькофф");
            paymentBox.Items.Add("Сбер");
            paymentBox.Items.Add("ВТБ");
            paymentBox.SelectedItem = "Оплата";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            resetAndSetSelectedStatusBox();
        }

        private void minusClick(object sender, EventArgs e)
        {
            numberBox.Text = (int.Parse(numberBox.Text) - 1).ToString();
        }

        private void plusClick(object sender, EventArgs e)
        {
            numberBox.Text = (int.Parse(numberBox.Text) + 1).ToString();
        }
    }
}
