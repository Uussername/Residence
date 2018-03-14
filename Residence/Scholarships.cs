using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residence
{
    public class Scholars : Resident
    {
        public string ResidentType { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string StudentID { get; set; }
        public string RoomNum { get; set; }
        public string RoomFloor { get; set; }
        public double Rent = 100;

        public Scholars(string ResidentType, string Fname, string Lname, string StudentID, string RoomNum, string RoomFloor)
        {
            this.ResidentType = ResidentType;
            this.Fname = Fname;
            this.Lname = Lname;
            this.StudentID = StudentID;
            this.RoomNum = RoomNum;
            this.RoomFloor = RoomFloor;
        }
    }
}