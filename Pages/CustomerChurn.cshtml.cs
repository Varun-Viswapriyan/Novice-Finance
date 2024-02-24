using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
   
    public class CustomerChurnModel : PageModel
    {
     


        public void OnGet()
        {
           
        }
        public void OnPost()
        {

           

                var creditScore = Request.Form["creditScore"];
                var location = Request.Form["location"];
                var gender = Request.Form["gender"];
                var age = Request.Form["age"];
                var tenure = Request.Form["tenure"];
                var numPurchases = Request.Form["numPurchases"];
                var creditCard = Request.Form["creditCard"];
                if (creditCard == "Yes")
                {
                    creditCard = "1";
                }
                else
                {
                    creditCard = "0";
                }
                var active = Request.Form["active"];
                if (active == "Yes")
                {
                    active = "1";
                }
                else
                {
                    active = "0";
                }

                var salary = Request.Form["salary"];
                CustomerChurnML.ModelInput sampleData = new CustomerChurnML.ModelInput()
                {
                    CreditScore = float.Parse(creditScore),
                    Geography = location,
                    Gender = gender,
                    Age = float.Parse(age),
                    Tenure = float.Parse(tenure),
                    NumOfProducts = float.Parse(numPurchases),
                    HasCrCard = float.Parse(creditCard),
                    IsActiveMember = float.Parse(active),
                    EstimatedSalary = float.Parse(salary),
                };

                // Make a single prediction on the sample data and print results
                var predictionResult = CustomerChurnML.Predict(sampleData);



                ViewData["topic"] = "There is a " + (100-((predictionResult.Score) * 100)) + " % chance the customer will exit";

        }
          
            

        }
    }

