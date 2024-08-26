namespace MossadMVC.View_Models
{
    public class ConnectPage1
    {
        public int countAllAgants { get; set; }
        public int countActiveAgants { get; set; }

        public int countAllTargets { get; set; }
        public int countKilledTargets { get; set; }


        public int countAllMissions { get; set; }
        public int countActiveMissions { get; set; }

        public string relativeAgantTargets { get; set; } = "";

        public string relativeAgantMissions { get; set; } = "";



    }


}
