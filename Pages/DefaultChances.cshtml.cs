using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class DefaultChancesModel : PageModel
    {
        int dummyVariable = 0;
        public void OnPost()
        {
            //var gender = Request.Form["gender"];
            var limitBalance = Request.Form["limitBalance"];
            var education = Request.Form["education"];
            var marriage = Request.Form["marriage"];
            var age = Request.Form["age"];



            var pay1 = Request.Form["status1"];
            var pay2 = Request.Form["status2"];
            var pay3 = Request.Form["status3"];
            var pay4 = Request.Form["status4"];
            var pay5 = Request.Form["status5"];
            var pay6 = Request.Form["status6"];

            var bill1 = Request.Form["bill1"];
            var bill2 = Request.Form["bill2"];
            var bill3 = Request.Form["bill3"];
            var bill4 = Request.Form["bill4"];
            var bill5 = Request.Form["bill5"];
            var bill6 = Request.Form["bill6"];

            var payment1 = Request.Form["payment1"];
            var payment2 = Request.Form["payment2"];
            var payment3 = Request.Form["payment3"];
            var payment4 = Request.Form["payment4"];
            var payment5 = Request.Form["payment5"];
            var payment6 = Request.Form["payment6"];

            //Load sample data
            DefaultML.ModelInput sampleData = new DefaultML.ModelInput()
            {
                LIMIT_BAL = float.Parse(limitBalance),
                SEX = @"male",
                EDUCATION = education,
                MARRIAGE = marriage,
                AGE = float.Parse(age),
                PAY_0 = float.Parse(pay1),
                PAY_2 = float.Parse(pay2),
                PAY_3 = float.Parse(pay3),
                PAY_4 = float.Parse(pay4),
                PAY_5 = float.Parse(pay5),
                PAY_6 = float.Parse(pay6),
                BILL_AMT1 = float.Parse(bill1),
                BILL_AMT2 = float.Parse(bill2),
                BILL_AMT3 = float.Parse(bill3),
                BILL_AMT4 = float.Parse(bill4),
                BILL_AMT5 = float.Parse(bill5),
                BILL_AMT6 = float.Parse(bill6),
                PAY_AMT1 = float.Parse(payment1),
                PAY_AMT2 = float.Parse(payment2),
                PAY_AMT3 = float.Parse(payment3),
                PAY_AMT4 = float.Parse(payment4),
                PAY_AMT5 = float.Parse(payment5),
                PAY_AMT6 = float.Parse(payment6),
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = DefaultML.Predict(sampleData);
            ViewData["message"] = "There is a " + (predictionResult.Score * 100) + " % chance for credit default";
            dummyVariable++;
        }
        

    }
}
