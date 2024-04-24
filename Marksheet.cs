namespace WebApplication9.Models
{
    public class Marksheet
    {
        public int MarkSheetId { get; set; }
        public int StudentId { get; set; }
        public string Subject { get; set; }
        public int TotalMark { get; set; }
        public int MarksObtained { get; set; }
    }
}
