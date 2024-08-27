using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using MossadMVC.Enums;

namespace MossadMVC.Models
{
    public class AgantDetailsMVc
    {

        public string nickname { get; set; } = "";

        public positionMVC position { get; set; } = new positionMVC();

        public AgantStatusEnum status { get; set; } = AgantStatusEnum.dormantAgent;

        public string LinkToMission { get; set; } = "";


    }
    }


