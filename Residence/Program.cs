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

            List<Resident> residents = new List<Resident>();
            Athletes athleteRes;
            Scholars scholarRes;
            Workers workerRes;

            string[] values;
            const string PATH = @"C:\Users\thoantj\OneDrive - dunwoody.edu\Advanced Programing\Projects\Residence\Residence_hall_info.csv";

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
        }
    }
}
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
    public Resident(string ResidentType, string Fname, string Lname, string StudentID, string RoomNum, string RoomFloor)
    {
        this.ResidentType = ResidentType;
        this.Fname = Fname;
        this.Lname = Lname;
        this.StudentID = StudentID;
        this.RoomNum = RoomNum;
        this.RoomFloor = RoomFloor;
    }
}
