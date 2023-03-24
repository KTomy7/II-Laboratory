namespace DataAccess.Models
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Code { get; set; }
        public ICollection<Faculty> Faculties { get; set; }
    }
}
