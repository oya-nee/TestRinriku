namespace TestRinriku.Models
{
    public class Person
    {
        public string? Name { get; set; }
        public required string Firstname { get; set; } 
        public string? Lastname { get; set; }

        public int? BirthYear {get; set;}
    }
}
