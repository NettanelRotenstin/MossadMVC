using System.ComponentModel.DataAnnotations;
 using Microsoft.AspNetCore.Components.Routing;
using MossadMVC.Enums;
using System.ComponentModel.DataAnnotations;

namespace MossadMVC.Models
{
    public class MissionMVC
    {


 
            [Key]
            public int? Id { get; set; }
            public agantMVC? agent { get; set; }

            public targetMVC? Target { get; set; }

            public double? timeLeft { get; set; }

            public MissionStatusEnum? status { get; set; }

            public List<agantMVC>? _agants { get; set; }

            public string? token { get; set; }

        }
    }
