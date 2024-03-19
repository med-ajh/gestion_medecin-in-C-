// AppointmentModel.cs
namespace YourAppName.Model
{
    public class AppointmentModel
    {
        public int AppointmentID { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public int PatientID { get; set; } // Foreign key linking to Patient
        public int DoctorID { get; set; } // Foreign key linking to Doctor
        // Other properties specific to the Appointment entity...
    }
}
