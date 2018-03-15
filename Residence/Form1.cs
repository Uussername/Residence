using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tabs.TabPages.Remove(HomeTab);
            Tabs.TabPages.Remove(NewTab);
            Tabs.TabPages.Remove(SearchTab);
        }
        private void loginEnter_Click(object sender, EventArgs e)
        {
            if (username.Text =="home" && password.Text =="1234")
            {
                Tabs.TabPages.Remove(LogIn); 
                Tabs.TabPages.Add(HomeTab);
                Tabs.TabPages.Add(NewTab);
                Tabs.TabPages.Add(SearchTab);
                username.Clear();
                password.Clear();
            }
            else
            {
                loginError.Show();
                password.Clear();
            }
        }
        private void logout_Click(object sender, EventArgs e)
        {
            Tabs.TabPages.Add(LogIn);
            Tabs.TabPages.Remove(HomeTab);
            Tabs.TabPages.Remove(NewTab);
            Tabs.TabPages.Remove(SearchTab);
        }
    
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() is "Athlete")
            {
                comboBox1.Hide();
            }
            if (comboBox2.SelectedItem.ToString() is "Student Worker")
            {
                comboBox1.Show();
            }
            if (comboBox2.SelectedItem.ToString() is "Scholarship")
            {

            }
        }
    }
}
