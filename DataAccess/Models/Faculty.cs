namespace DataAccess.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UniversityCode { get; set; }
        public Univeristy University { get; set; }
    }
}
