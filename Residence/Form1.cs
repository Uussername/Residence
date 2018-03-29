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
        //initial login screen, removes everything but login
        public Form1()
        {
            InitializeComponent();
            Tabs.TabPages.Remove(HomeTab);
            Tabs.TabPages.Remove(NewTab);
            Tabs.TabPages.Remove(SearchTab);
        }

        //Login enter button, only adds tabs if user name is home and password is 1234
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

        //clicked logout button from home, readds login tab, removes all other tabs
        private void logout_Click(object sender, EventArgs e)
        {
            Tabs.TabPages.Add(LogIn);
            Tabs.TabPages.Remove(HomeTab);
            Tabs.TabPages.Remove(NewTab);
            Tabs.TabPages.Remove(SearchTab);
        }

        //resident type box closed, changes floor combobox (comboBox1) to available floors
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text is "Athlete")
            {
                comboBox5.SelectedIndex = 0;
                comboBox5.Hide();
                label13.Hide();
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                object[] floors = new object[] { 4, 5, 6 };
                comboBox1.Items.AddRange(floors);
            }
            if (comboBox2.Text is "Worker")
            {
                comboBox5.Show();
                label13.Show();
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                object[] floors = new object[] { 1, 2, 3 };
                comboBox1.Items.AddRange(floors);
            }
            if (comboBox2.Text is "Scholarship")
            {
                comboBox5.SelectedIndex = 0;
                comboBox5.Hide();
                label13.Hide();
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                object[] floors = new object[] { 7, 8 };
                comboBox1.Items.AddRange(floors);
            }
        }

        //floor box closed, changes room number box (comboBox3) to available rooms on that floor
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text is "1")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 101, 102, 103, 104, 105, 106, 107, 108, 109, 110 };
                comboBox3.Items.AddRange(rooms);
            }
            if (comboBox1.Text is "2")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 201, 202, 203, 204, 205, 206, 207, 208, 209, 210 };
                comboBox3.Items.AddRange(rooms);
            }
            if (comboBox1.Text is "3")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 301, 302, 303, 304, 305, 306, 307, 308, 309, 310 };
                comboBox3.Items.AddRange(rooms);
            }
            if (comboBox1.Text is "4")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 401, 402, 403, 404, 405, 406, 407, 408, 409, 410 };
                comboBox3.Items.AddRange(rooms);
            }
            if (comboBox1.Text is "5")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 501, 502, 503, 504, 505, 506, 507, 508, 509, 510 };
                comboBox3.Items.AddRange(rooms);
            }
            if (comboBox1.Text is "6")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 601, 602, 603, 604, 605, 606, 607, 608, 609, 610 };
                comboBox3.Items.AddRange(rooms);
            }
            if (comboBox1.Text is "7")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 701, 702, 703, 704, 705, 706, 707, 708, 709, 710 };
                comboBox3.Items.AddRange(rooms);
            }
            if (comboBox1.Text is "8")
            {
                comboBox3.Items.Clear();
                object[] rooms = new object[] { 801, 802, 803, 804, 805, 806, 807, 808, 809, 810 };
                comboBox3.Items.AddRange(rooms);
            }
        }
        //user must check box in order to submit data
        private void Verify_CheckedChanged(object sender, EventArgs e)
        {
            if (Verify.Checked == true)
            {
                submit.Show();
            }
            if (Verify.Checked == false)
            {
                submit.Hide();
            }
        }

        //submit button on new resident creates a new resident if the student id doesn't match any other and all fields are filled
        private void submit_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null || textBox1.Text == "" || textBox2.Text== "" ||
                textBox3.Text == "" || comboBox3.SelectedItem == null || comboBox1.SelectedItem == null)
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
            string inp1 = textBox1.Text.ToString().ToLower();
            inp1 = inp1.First().ToString().ToUpper() + inp1.Substring(1);

            string inp2 = textBox2.Text.ToString().ToLower();
            inp2 = inp2.First().ToString().ToUpper() + inp2.Substring(1);

            string newEntry = $"{comboBox2.Text},{inp1},{inp2}," +
                $"{textBox3.Text},{comboBox3.Text},{comboBox1.Text}, {comboBox5.Text}";
            Files.WRITE(newEntry);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox2.SelectedItem = null;
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            comboBox5.SelectedIndex = 0;
            comboBox5.Hide();
            label13.Hide();
            success.Show();
        }

        //re hides success message after clicking again, after submiting a new resident
        private void success_MouseClick(object sender, MouseEventArgs e)
        {
            success.Hide();
        }

        //opens New Resident tab
        private void button1_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 1;
        }

        //opens Seatch Resident tab
        private void button2_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 2;
        }

        //home button on new resident, brings to home tab
        private void button4_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 0;
        }

        //home button on search resident, brings to home tab
        private void button3_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 0;
        }

        //when search clicked, reads file and looks for specific data in specified field
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == null || textBox6.Text == "")
            {
                MessageBox.Show("One or more required fields are empty", "Information error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //retrives and displays data
            void Search(ref List<Resident> residentz, int x)
            {
                SFname.Text = residentz[x].Fname;
                SLname.Text = residentz[x].Lname;
                SResType.Text = residentz[x].ResidentType;
                SStudID.Text = residentz[x].StudentID;
                SFloor.Text = residentz[x].RoomFloor;
                SRoom.Text = residentz[x].RoomNum;
                SRent.Text = $"${residentz[x].Rent.ToString()}";
            }
            //resets all the text labels, clears search box
            void Reset()
            {
                label9.Hide();
                SFname.Text = "";
                SLname.Text = "";
                SResType.Text = "";
                SStudID.Text = "";
                SFloor.Text = "";
                SRoom.Text = "";
                SRent.Text = "";
            }      
            string input = textBox6.Text.ToString().ToLower();
            input = input.First().ToString().ToUpper() + input.Substring(1);
            List<Resident> residents = new List<Resident>();
            Files.READ(ref residents);
         
            if (comboBox4.Text is "First Name")
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

            if (comboBox4.Text is "Last Name")
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

            if (comboBox4.Text is "Student ID")
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
            textBox6.Clear();
            comboBox4.SelectedItem = null;
        }

        //when search by comboBox(4) closed clears the search field (textBox6) 
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Clear();
        }
    }

    //class for file operation methods
    public class Files
    {
        //Reads file
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
                    athleteRes = new Athletes(values[0], values[1], values[2], values[3], values[4], values[5], values[6]);
                    residents.Add(athleteRes);
                }
                if (values[0] == "Worker")
                {
                    workerRes = new Workers(values[0], values[1], values[2], values[3], values[4], values[5], values[6]);
                    residents.Add(workerRes);
                }
                if (values[0] == "Scholarship")
                {
                    scholarRes = new Scholars(values[0], values[1], values[2], values[3], values[4], values[5], values[6]);
                    residents.Add(scholarRes);
                }
            }
            read.Close(); //close read stream
            file.Close(); //close file stream
            return;
        }

        //writes to file
        public static void WRITE(string entry)
        {
            using (StreamWriter sw = new StreamWriter(PATH, append: true))
            {
                sw.WriteLine(entry);
                sw.Close();
            }
        }
    }
}
