using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public abstract class Resident
{
    public string ResidentType { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public int StudentID { get; set; }
    public int RoomNum { get; set; }
    public int RoomFloor { get; set; }
    public double Rent;

    public Resident(string ResidentType, string Fname, string Lname, int StudentID, int RoomNum, int RoomFloor)
	{
        this.ResidentType = ResidentType;
        this.Fname = Fname;
        this.Lname = Lname;
        this.StudentID = StudentID;
        this.RoomNum = RoomNum;
        this.RoomFloor = RoomFloor;
    }
}
