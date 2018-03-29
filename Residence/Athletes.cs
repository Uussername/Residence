using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residence
{
    public class Athletes : Resident
    {
        public Athletes(string ResidentType, string Fname, string Lname, string StudentID, string RoomNum, string RoomFloor, string Hours)
        {
            this.ResidentType = ResidentType;
            this.Fname = Fname;
            this.Lname = Lname;
            this.StudentID = StudentID;
            this.RoomNum = RoomNum;
            this.RoomFloor = RoomFloor;
            this.Rent = 1245.00;
            this.Hours = Hours;
        }
    }
}
