using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Residence
{
    public class Athletes : Resident
    {
        double Rent = 1245.00;

        public Athletes(string ResidentType, string Fname, string Lname, string StudentID, string RoomNum, string RoomFloor)
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
