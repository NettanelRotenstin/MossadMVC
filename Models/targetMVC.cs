 using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Routing;
using MossadMVC.Enums;

namespace MossadMVC.Models
{
    public class targetMVC
    {


 
            [Key]
            public int id { get; set; }

            private string? name { get; set; }

            private string? position { get; set; }

            public string? photo_url { get; set; }

            public positionMVC? location { get; set; }

            public TargetStatusEnum? status { get; set; }
        }
    }
