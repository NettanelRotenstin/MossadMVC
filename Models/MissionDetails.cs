using MossadMVC.Enums;
using System.ComponentModel.DataAnnotations;

namespace MossadMVC.Models
{
    public class MissionDetails
    {
        
        public int? id { get; set; } 

         public agantMVC? agent { get; set; }= new agantMVC();

        public targetMVC? Target { get; set; } = new targetMVC();

        public double? timeLeft { get; set; }

        public MissionStatusEnum? status { get; set; }

        public List<agantMVC>? _agants { get; set; } = new List<agantMVC>();
    }
}
