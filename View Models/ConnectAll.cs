using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.Extensions.DependencyModel;
using MossadMVC.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;


namespace MossadMVC.View_Models
{
    public class ConnectAll
    {
    
        public List<agantMVC> agantsMVCs { get; set; } = new List<agantMVC>();

        public agantMVC agantMVC { get; set; }

        public List<targetMVC> targetsMVC { get; set; } = new List<targetMVC>();

        public targetMVC targetMVC { get; set; }


        public List<MissionMVC> missionsMVC { get; set; }

        public MissionMVC missionMVC { get; set; }
 
        public string CountAllAgants {  get; set; }
     }
}
