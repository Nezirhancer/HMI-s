using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS1Autoprinter
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Attach the event handler to the KeyDown event for the TextBox
            textBox2.KeyDown += TextBox2_KeyDown;
        }
        public int GetWeekNumber(DateTime dtPassed) => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        private string date() => DateTime.Now.ToString("yy");
        private string date1() => DateTime.Now.ToString("yyyy");
        private string dateMonth() => DateTime.Now.ToString("MM");
        private string dateMonthofday() => DateTime.Now.ToString("dd");

        private string week() => this.GetWeekNumber(DateTime.Now).ToString();
        private void button1_Click(object sender, EventArgs e)//Login button
        {
            string id = textBox1.Text;
            string password = textBox2.Text;
            string password_control = dateMonthofday() + dateMonth();
            if ((id == "balta" && password == dateMonthofday() + dateMonth()))
            {
                Form1 Form1_ = new Form1();

                // Show the second form
                Form1_.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Şifre Yanlış ! ");
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Perform your custom action here
                PerformAction();
            }
        }

        private void PerformAction()
        {
            string id = textBox1.Text;
            string password = textBox2.Text;
            string password_control = dateMonthofday() + dateMonth();
            if (id == "balta" && password == dateMonthofday() + dateMonth())
            {
                Form1 Form1_ = new Form1();

                // Show the second form
                Form1_.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Şifre Yanlış ! ");
        }
    }
}
