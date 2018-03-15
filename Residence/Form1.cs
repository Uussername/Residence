using System;
using System.Collections.Generic;
using System.IO;
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
            if (username.Text == "home" && password.Text == "1234")
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
        private void comboBox2_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedItem.ToString() is "Athlete")
                {
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                object[] floors = new object[] { 4, 5, 6 };
                comboBox1.Items.AddRange(floors);
                }
                if (comboBox2.SelectedItem.ToString() is "Student Worker")
                {
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                object[] floors = new object[] { 1, 2, 3 };
                comboBox1.Items.AddRange(floors);
                }
                if (comboBox2.SelectedItem.ToString() is "Scholarship")
                {
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                object[] floors = new object[] { 7, 8 };
                comboBox1.Items.AddRange(floors);
                }
            }
            catch (NullReferenceException)
            {

            }
        }


        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() is "1")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };
                    comboBox3.Items.AddRange(rooms);
                }
                if (comboBox1.SelectedItem.ToString() is "2")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 201, 202, 203, 204, 205, 206, 207, 208, 209, 210 };
                    comboBox3.Items.AddRange(rooms);
                }
                if (comboBox1.SelectedItem.ToString() is "3")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 301, 302, 303, 304, 305, 306, 307, 308, 309, 310 };
                    comboBox3.Items.AddRange(rooms);
                }
                if (comboBox1.SelectedItem.ToString() is "4")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 401, 402, 403, 404, 405, 406, 407, 408, 409, 410 };
                    comboBox3.Items.AddRange(rooms);
                }
                if (comboBox1.SelectedItem.ToString() is "5")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 501, 502, 503, 504, 505, 506, 507, 508, 509, 510 };
                    comboBox3.Items.AddRange(rooms);
                }
                if (comboBox1.SelectedItem.ToString() is "6")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 601, 602, 603, 604, 605, 606, 607, 608, 609, 610 };
                    comboBox3.Items.AddRange(rooms);
                }
                if (comboBox1.SelectedItem.ToString() is "7")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 701, 702, 703, 704, 705, 706, 707, 708, 709, 710 };
                    comboBox3.Items.AddRange(rooms);
                }
                if (comboBox1.SelectedItem.ToString() is "8")
                {
                    comboBox3.Items.Clear();
                    object[] rooms = new object[] { 801, 802, 803, 804, 805, 806, 807, 808, 809, 810 };
                    comboBox3.Items.AddRange(rooms);
                }
            }
            catch (NullReferenceException)
            {

            }
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null || textBox1.Text == null || textBox2.Text== null ||
                textBox3.Text == null || comboBox3.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("One or more fields are empty", "Information error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Resident> residents = new List<Resident>();
            Files.READ(ref residents);
            for (var x = 0; x < residents.Count(); x++)
            {
                if (residents[x].StudentID == textBox3.Text.ToString())
                {
                    MessageBox.Show("Student ID matches an existing Student in Residence Hall", "Student ID error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Clear();
                    return;
                }
            }
            string newEntry = $"{comboBox2.SelectedItem.ToString()},{textBox1.Text.ToString()},{textBox2.Text.ToString()}," +
                $"{textBox3.Text.ToString()},{comboBox3.SelectedItem.ToString()},{comboBox1.SelectedItem.ToString()}";
            Files.WRITE(newEntry);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox2.SelectedItem = null;
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            success.Show();
        }

        private void success_MouseClick(object sender, MouseEventArgs e)
        {
            success.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 0;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            void Search(ref List<Resident> residentz, int x)
            {
                SFname.Text = residentz[x].Fname;
                SLname.Text = residentz[x].Lname;
                SResType.Text = residentz[x].ResidentType;
                SStudID.Text = residentz[x].StudentID;
                SFloor.Text = residentz[x].RoomFloor;
                SRoom.Text = residentz[x].RoomNum;
            }
            void Reset()
            {
                label9.Hide();
                SFname.Text = "";
                SLname.Text = "";
                SResType.Text = "";
                SStudID.Text = "";
                SFloor.Text = "";
                SRoom.Text = "";
            }
            string input = textBox6.Text.ToString();
            input = input.First().ToString().ToUpper() + input.Substring(1);
            List<Resident> residents = new List<Resident>();
            Files.READ(ref residents);
            if (comboBox4.SelectedItem.ToString() is "First Name")
            {
                Reset();
                for (var x = 0; x < residents.Count(); x++)
                {
                    if (residents[x].Fname == input)
                    {
                        Search(ref residents, x);
                    }
                }
                if (SFname.Text == "")
                {
                    label9.Show();
                }
            }
            if (comboBox4.SelectedItem.ToString() is "Last Name")
            {
                Reset();
                for (var x = 0; x < residents.Count(); x++)
                {
                    if (residents[x].Lname == input)
                    {
                        Search(ref residents, x);
                    }
                }
                if (SFname.Text == "")
                {
                    label9.Show();
                }
            }
            if (comboBox4.SelectedItem.ToString() is "Student ID")
            {
                Reset();
                for (var x = 0; x < residents.Count(); x++)
                {
                    if (residents[x].StudentID == textBox6.Text.ToString())
                    {
                        Search(ref residents, x);
                    }
                }
                if (SFname.Text == "")
                {
                    label9.Show();
                }
            }
        }
    }
    public class Files
    {
        const string PATH = @"C:\Users\thoantj\OneDrive - dunwoody.edu\Advanced Programing\Projects\Residence\Residence_hall_info.csv";
        public static void READ(ref List<Resident> residents)
        {
            Athletes athleteRes;
            Scholars scholarRes;
            Workers workerRes;

            string[] values;

            FileStream file = new FileStream(PATH, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(file);
            read.ReadLine(); // remove the worthless header
            while (!read.EndOfStream)
            {
                values = read.ReadLine().Split(',');
                if (values[0] == "Athlete")
                {
                    athleteRes = new Athletes(values[0], values[1], values[2], values[3], values[4], values[5]);
                    residents.Add(athleteRes);
                }
                if (values[0] == "Worker")
                {
                    workerRes = new Workers(values[0], values[1], values[2], values[3], values[4], values[5]);
                    residents.Add(workerRes);
                }
                if (values[0] == "Scholarship")
                {
                    scholarRes = new Scholars(values[0], values[1], values[2], values[3], values[4], values[5]);
                    residents.Add(scholarRes);
                }
            }
            read.Close(); //close read stream
            file.Close(); //close file stream
            return;
        }
        public static void WRITE(string entry)
        {
            using (StreamWriter sw = new StreamWriter(PATH, append: true))
            {
                sw.WriteLine(entry);
            }
        }
    }
}
