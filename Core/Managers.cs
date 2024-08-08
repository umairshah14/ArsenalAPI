using System.ComponentModel.DataAnnotations;
namespace ARSENAL_API_2.Core
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string StartDate { get; set; }
        public string Photo { get; set; }

    }

}

