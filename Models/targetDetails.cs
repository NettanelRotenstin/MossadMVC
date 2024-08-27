using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using MossadMVC.Enums;

namespace MossadMVC.Models
{
    public class targetDetails
    {
        public positionMVC position { get; set; } = new positionMVC();

        public TargetStatusEnum status { get; set; } = TargetStatusEnum.alive;

        public string name { get; set; } = "";

        public string photo_url { get; set; } = "";
    }
}
