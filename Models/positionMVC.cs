using System.ComponentModel.DataAnnotations;

namespace MossadMVC.Models
{
    public class positionMVC
    {
 
 
            [Key]
            public int Id { get; set; }

            [Range(0, 1000)]
            public int x { get; set; }

            [Range(0, 1000)]
            public int y { get; set; }
        }
    }

