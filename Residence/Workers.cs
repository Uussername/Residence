using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residence
{
    public class Workers : Resident
    {
        public Workers(string ResidentType, string Fname, string Lname, string StudentID, string RoomNum, string RoomFloor, string Hours)
        {
            this.ResidentType = ResidentType;
            this.Fname = Fname;
            this.Lname = Lname;
            this.StudentID = StudentID;
            this.RoomNum = RoomNum;
            this.RoomFloor = RoomFloor;
            this.Hours = Hours;
            this.Rent = 1245.00 - (Int32.Parse(Hours) * 14);
        }
    }
}