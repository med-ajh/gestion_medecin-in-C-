namespace YourAppName.Model
{
    public class MedicalRecordModel
    {
        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
    }
}
