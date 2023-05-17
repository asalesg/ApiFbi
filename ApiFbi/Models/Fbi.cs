using System.ComponentModel.DataAnnotations;

namespace ApiFbi.Models
{
    public class Fbi
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Sex { get; set; }
        public string? Description { get; set; }
        public string? Nationality { get; set; }

        public Fbi()
        {
        }

        public Fbi(int id, string? title, string? url, string? sex, string? description, string? nationality)
        {
            Id = id;
            Title = title;
            Url = url;
            Sex = sex;
            Description = description;
            Nationality = nationality;
        }
    }
}
