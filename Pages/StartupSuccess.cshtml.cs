using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class StartupSuccessModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            var yearFounding = Request.Form["yearFounding"];
            var numInvestors =  Request.Form["numInvestorsSeed"];
            var numCoFounders = Request.Form["numCo-founders"];
            var numAdvisors = Request.Form["numAdvisors"];
            var teamSize = Request.Form["teamSize"];
            var repeatInvestors = Request.Form["numRepeatInvestors"];
            var avgSize = Request.Form["avgSizePast"];
            var productService = Request.Form["pdctService"];
            var privaPublic = Request.Form["privatePublic"];
            var strucUnstruc = Request.Form["structUnstruc"];
            var cloudPlat = Request.Form["cloudPlat"];
            var locGlob = Request.Form["localGlob"];
            var linNonlin = Request.Form["linNonlin"];
            var crowdFund = Request.Form["crowdfunding"];
            var onlineOff = Request.Form["onlineOffline"];
            var highEd = Request.Form["highEd"];
            var exp = Request.Form["expSellBuild"];
            var diff = Request.Form["diffWokForce"];
            var timeMkt = Request.Form["timeMarket"];
            var dirCompet = Request.Form["directCompets"];
            var lastRound = Request.Form["lastRound"];
            var Invest1 = Request.Form["invest1"];
            var avgInvest = Request.Form["avgInvest"];
            var cycle = Request.Form["GartnerState"];


            StartupSuccess.ModelInput sampleData = new StartupSuccess.ModelInput()
            {
                Year_of_founding = float.Parse(yearFounding),
                Number_of_Investors_in_Seed = float.Parse(numInvestors),
                Number_of_Co_founders = float.Parse(numCoFounders),
                Number_of_of_advisors = float.Parse(numAdvisors),
                Team_size_all_employees = float.Parse(teamSize),
                Number_of_of_repeat_investors = float.Parse(repeatInvestors),
                Average_size_of_companies_worked_for_in_the_past = avgSize,
                Product_or_service_company_ = productService,
                Focus_on_private_or_public_data_ = privaPublic,
                Focus_on_structured_or_unstructured_data = strucUnstruc,
                Cloud_or_platform_based_serive_product_ = cloudPlat,
                Local_or_global_player = locGlob,
                Linear_or_Non_linear_business_model = linNonlin,
                Crowdfunding_based_business = crowdFund,
                Online_or_offline_venture___physical_location_based_business_or_online_venture_ = onlineOff,
                Highest_education = highEd,
                Experience_in_selling_and_building_products = exp,
                Dificulty_of_Obtaining_Work_force = diff,
                Time_to_market_service_or_product = timeMkt,
                Number_of_Direct_competitors = float.Parse(dirCompet),
                Last_round_of_funding_received__in_milionUSD_ = lastRound,
                Time_to_1st_investment__in_months_ = float.Parse(Invest1),
                Avg_time_to_investment___average_across_all_rounds__measured_from_previous_investment = float.Parse(avgInvest),
                Gartner_hype_cycle_stage = cycle,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = StartupSuccess.Predict(sampleData);

            // Make a single prediction on the sample data and print results
           
            ViewData["message"] = "There is a "+ (predictionResult.Score *100) + " % chance that your startup will be a success";
        }
    }
}
