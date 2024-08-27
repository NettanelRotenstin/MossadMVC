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
 

             //get api all agants details
            var resultAllAgantDetails = await _httpClient.GetFromJsonAsync<AgantDetailsMVc[]>("http://localhost:5157/api/agants/allDetails");
            //converting to the viewmodel
            
            return View(resultAllAgantDetails);
        }

        public async Task<IActionResult> oneDetails(int id)
        {


             //get api all agants details
            var resultAgantDetails = await _httpClient.GetFromJsonAsync<AgantDetailsMVc[]>("http://localhost:5157/api/agants/allDetails");
            //converting to the viewmodel
 
            return View(resultAgantDetails);
        }

        public async Task<IActionResult> Page3()
        {
 
            //get api all agants details
            var resultAllAgantDetails = await _httpClient.GetFromJsonAsync<targetDetails[]>("http://localhost:5157/api/targets/allDetails");
            //converting to the viewmodel
 

             

            return View(resultAllAgantDetails);




             
        }

        public async Task<IActionResult> allMissions()
        {

            //get api all agants details
            var resultAllAgantDetails = await _httpClient.GetFromJsonAsync<MissionDetails[]>("http://localhost:5157/api/missions/allMissions");
            //converting to the viewmodel




            return View(resultAllAgantDetails);





        }

        public async Task<IActionResult> Active(int id)
        {
 
            //get api all agants details
            await _httpClient.PutAsJsonAsync($"http://localhost:5157/api/missions/{id}", "assigned");
            //converting to the viewmodel
            




            return RedirectToAction("allMissions");





        }

        public async Task<IActionResult> Update()
        {

            //get api all agants details
            await _httpClient.PutAsJsonAsync("http://localhost:5157/api/missions/update","");
            //converting to the viewmodel





            return RedirectToAction("allMissions");





        }

    }
}