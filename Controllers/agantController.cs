using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using MossadMVC.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using MossadMVC.View_Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MossadMVC.Controllers
{
    public class agantController : Controller
    {

        private readonly HttpClient _httpClient;

        public agantController()
        {
            _httpClient = new HttpClient();
        }


        public async Task<IActionResult> Page1()
        {
            ConnectPage1 page1 = new ConnectPage1();


            //get api count all agants
            var resultCountAllAgant = await _httpClient.GetStringAsync("http://localhost:5157/api/agants/count");
            //converting to the viewmodel
            page1.countAllAgants = JsonConvert.DeserializeObject<int>(resultCountAllAgant);


            //get api count active agants
            var resultActiveAgants = await _httpClient.GetStringAsync("http://localhost:5157/api/agants/Activecount");
            //converting to the viewmodel

            page1.countActiveAgants = JsonConvert.DeserializeObject<int>(resultActiveAgants);




            //get api count all targets
            var resultCountAllTargets = await _httpClient.GetStringAsync("http://localhost:5157/api/targets/count");
            //converting to the viewmodel

            page1.countAllTargets = JsonConvert.DeserializeObject<int>(resultCountAllTargets);


            //get api count all killed targets
            var resultCountKilled = await _httpClient.GetStringAsync("http://localhost:5157/api/targets/KilledCount");
            //converting to the viewmodel

            page1.countKilledTargets = JsonConvert.DeserializeObject<int>(resultCountKilled);



            //get api count all Missiles  
            var resultCountMissions = await _httpClient.GetStringAsync("http://localhost:5157/api/missions/count");
            //converting to the viewmodel

            page1.countAllMissions = JsonConvert.DeserializeObject<int>(resultCountMissions);


            //get api count active Missiles  
            var resultCountActiveMissions = await _httpClient.GetStringAsync("http://localhost:5157/api/missions/Activecount");
            //converting to the viewmodel

            page1.countActiveMissions = JsonConvert.DeserializeObject<int>(resultCountActiveMissions);

            //get api relative agant to targets 
            var resultRelativeAgantTargets = await _httpClient.GetStringAsync("http://localhost:5157/api/agants/relativeCount");
            //converting to the viewmodel

            page1.relativeAgantTargets =  resultRelativeAgantTargets;

            //get api relative agant to missions 
            var resultRelativeAgantMissions = await _httpClient.GetStringAsync("http://localhost:5157/api/agants/relativeAgantRoleCount");
            //converting to the viewmodel

            page1.relativeAgantMissions =   resultRelativeAgantMissions;







            return View(page1);
        }

        public async Task<IActionResult> Page2()
        {
            ConnectPage2 page2 = new ConnectPage2();

            //get api all agants details
            var resultAllAgantDetails = await _httpClient.GetStringAsync("http://localhost:5157/api/agants//allDetails");
            //converting to the viewmodel
            page2._allAgantsDetails = JsonConvert.DeserializeObject<List<agantMVC>>(resultAllAgantDetails);
           
            
            
            
            
            
            
            return View();
        }

        public async Task<IActionResult> Page3()
        {
            ConnectPage3 page3 = new ConnectPage3();

            //get api all agants details
            var resultAllAgantDetails = await _httpClient.GetStringAsync("http://localhost:5157/api/targets/allDetails");
            //converting to the viewmodel
            page3.targetMVCs = JsonConvert.DeserializeObject<List<string>>(resultAllAgantDetails);







            return View();
        }


    }
}