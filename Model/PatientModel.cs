namespace 
;
public class AppointmentModel
{
    public int AppointmentID { get; set; }
    public DateTime AppointmentDateTime { get; set; }
    public int PatientID { get; set; } 

    public AppointmentModel(int AppointmentID, DateTime AppointmentDateTime, int PatientID) { 
        this.AppointmentID = AppointmentID;
        this.AppointmentDateTime = AppointmentDateTime;
        this.PatientID = PatientID;
    
    }

}
