using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class LoanApprovalModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            var gender = Request.Form["gender"];
            var dependents = Request.Form["dependents"];
            var education = Request.Form["education"];
            var applicantIncome = Request.Form["applicantIncome"];
            var coapplicantIncome = Request.Form["coApplicantIncome"];
            var loanAmount = Request.Form["loanAmnt"];
            var loanTerm=Request.Form["loanTerm"];
            var propArea = Request.Form["propArea"];

            LoanApprovalML.ModelInput sampleData = new LoanApprovalML.ModelInput()
            {
                Gender = gender,
                Dependents = float.Parse(dependents),
                Education = education,
                ApplicantIncome = float.Parse(applicantIncome),
                Coapplica0tI0come = float.Parse(coapplicantIncome),
                LoanAmount = float.Parse(loanAmount),
                Loan_Amount_Term = float.Parse(loanTerm),
                Propert1_Area = propArea
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = LoanApprovalML.Predict(sampleData);
            
            ViewData["message"] = "There is a " +(predictionResult.Score *100)
                + " % chance that the loan will be approved";
        }


    }
}
