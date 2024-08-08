using System.ComponentModel.DataAnnotations;

namespace ARSENAL_API_2.Core
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public int ShirtNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Nationality { get; set; }

        public string Position { get; set; }

        public string Photo { get; set; }
    }
}