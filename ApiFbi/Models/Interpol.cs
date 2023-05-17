using System.ComponentModel.DataAnnotations;

namespace ApiFbi.Models
{
    public class Interpol
    {
        [Key]
        public int  EntityId { get; set; }
        public string? Forename { get; set; }

        public string? Name { get; set; }

        public string? Nationalities { get; set; }


        public Interpol()
        {
        }

        public Interpol(int entityId, string? forename, string? name, string? nacionalities)
        {
            EntityId = entityId;
            Forename = forename;
            Name = name;
            Nationalities = nacionalities;
        }

    }




}
