using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residence
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    //Resident Parent class
    public abstract class Resident
    {
        public string ResidentType { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string StudentID { get; set; }
        public string RoomNum { get; set; }
        public string RoomFloor { get; set; }
        public double Rent;
        public Resident()
        {
        }
    }
}
