using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Routing;
using MossadMVC.Enums;
 
namespace MossadMVC.Models
{
    public class agantMVC
    {

 
            [Key]
            public int id { get; set; }

            private string? nickname { get; set; }

            private string? photo_url { get; set; }

            //class of x y
            public positionMVC? location { get; set; }

            //enum for status
            public AgantStatusEnum? status { get; set; } = AgantStatusEnum.activeAgant;

            public int? counterKilled { get; set; }
        }
    }

