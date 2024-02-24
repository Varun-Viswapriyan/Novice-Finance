﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace WebApplication4
{
    public partial class StartupSuccess
    {
        /// <summary>
        /// model input class for StartupSuccess.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Dependent-Company Status")]
            public float Dependent_Company_Status { get; set; }

            [ColumnName(@"year of founding")]
            public float Year_of_founding { get; set; }

            [ColumnName(@"Number of Investors in Seed")]
            public float Number_of_Investors_in_Seed { get; set; }

            [ColumnName(@"Number of Co-founders")]
            public float Number_of_Co_founders { get; set; }

            [ColumnName(@"Number of of advisors")]
            public float Number_of_of_advisors { get; set; }

            [ColumnName(@"Team size all employees")]
            public float Team_size_all_employees { get; set; }

            [ColumnName(@"Number of of repeat investors")]
            public float Number_of_of_repeat_investors { get; set; }

            [ColumnName(@"Worked in top companies")]
            public bool Worked_in_top_companies { get; set; }

            [ColumnName(@"Average size of companies worked for in the past")]
            public string Average_size_of_companies_worked_for_in_the_past { get; set; }

            [ColumnName(@"Have been part of successful startups in the past?")]
            public bool Have_been_part_of_successful_startups_in_the_past_ { get; set; }

            [ColumnName(@"Consulting experience?")]
            public bool Consulting_experience_ { get; set; }

            [ColumnName(@"Product or service company?")]
            public string Product_or_service_company_ { get; set; }

            [ColumnName(@"Focus on private or public data?")]
            public string Focus_on_private_or_public_data_ { get; set; }

            [ColumnName(@"Focus on consumer data?")]
            public bool Focus_on_consumer_data_ { get; set; }

            [ColumnName(@"Focus on structured or unstructured data")]
            public string Focus_on_structured_or_unstructured_data { get; set; }

            [ColumnName(@"Subscription based business")]
            public bool Subscription_based_business { get; set; }

            [ColumnName(@"Cloud or platform based serive/product?")]
            public string Cloud_or_platform_based_serive_product_ { get; set; }

            [ColumnName(@"Local or global player")]
            public string Local_or_global_player { get; set; }

            [ColumnName(@"Linear or Non-linear business model")]
            public string Linear_or_Non_linear_business_model { get; set; }

            [ColumnName(@"Capital intensive business e.g. e-commerce, Engineering products and operations can also cause a business to be capital intensive")]
            public bool Capital_intensive_business_e_g__e_commerce__Engineering_products_and_operations_can_also_cause_a_business_to_be_capital_intensive { get; set; }

            [ColumnName(@"Crowdsourcing based business")]
            public bool Crowdsourcing_based_business { get; set; }

            [ColumnName(@"Crowdfunding based business")]
            public string Crowdfunding_based_business { get; set; }

            [ColumnName(@"Machine Learning based business")]
            public bool Machine_Learning_based_business { get; set; }

            [ColumnName(@"Predictive Analytics business")]
            public bool Predictive_Analytics_business { get; set; }

            [ColumnName(@"Speech analytics business")]
            public bool Speech_analytics_business { get; set; }

            [ColumnName(@"Prescriptive analytics business")]
            public bool Prescriptive_analytics_business { get; set; }

            [ColumnName(@"Big Data Business")]
            public bool Big_Data_Business { get; set; }

            [ColumnName(@"Cross-Channel Analytics/ marketing channels")]
            public bool Cross_Channel_Analytics__marketing_channels { get; set; }

            [ColumnName(@"Online or offline venture - physical location based business or online venture?")]
            public string Online_or_offline_venture___physical_location_based_business_or_online_venture_ { get; set; }

            [ColumnName(@"Highest education")]
            public string Highest_education { get; set; }

            [ColumnName(@"Experience in selling and building products")]
            public string Experience_in_selling_and_building_products { get; set; }

            [ColumnName(@"Dificulty of Obtaining Work force")]
            public string Dificulty_of_Obtaining_Work_force { get; set; }

            [ColumnName(@"Time to market service or product")]
            public string Time_to_market_service_or_product { get; set; }

            [ColumnName(@"Barriers of entry for the competitors")]
            public bool Barriers_of_entry_for_the_competitors { get; set; }

            [ColumnName(@"Number of Direct competitors")]
            public float Number_of_Direct_competitors { get; set; }

            [ColumnName(@"Last round of funding received (in milionUSD)")]
            public string Last_round_of_funding_received__in_milionUSD_ { get; set; }

            [ColumnName(@"Time to 1st investment (in months)")]
            public float Time_to_1st_investment__in_months_ { get; set; }

            [ColumnName(@"Avg time to investment - average across all rounds, measured from previous investment")]
            public float Avg_time_to_investment___average_across_all_rounds__measured_from_previous_investment { get; set; }

            [ColumnName(@"Gartner hype cycle stage")]
            public string Gartner_hype_cycle_stage { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for StartupSuccess.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Dependent-Company Status")]
            public float Dependent_Company_Status { get; set; }

            [ColumnName(@"year of founding")]
            public float Year_of_founding { get; set; }

            [ColumnName(@"Number of Investors in Seed")]
            public float Number_of_Investors_in_Seed { get; set; }

            [ColumnName(@"Number of Co-founders")]
            public float Number_of_Co_founders { get; set; }

            [ColumnName(@"Number of of advisors")]
            public float Number_of_of_advisors { get; set; }

            [ColumnName(@"Team size all employees")]
            public float Team_size_all_employees { get; set; }

            [ColumnName(@"Number of of repeat investors")]
            public float Number_of_of_repeat_investors { get; set; }

            [ColumnName(@"Worked in top companies")]
            public float[] Worked_in_top_companies { get; set; }

            [ColumnName(@"Average size of companies worked for in the past")]
            public float[] Average_size_of_companies_worked_for_in_the_past { get; set; }

            [ColumnName(@"Have been part of successful startups in the past?")]
            public float[] Have_been_part_of_successful_startups_in_the_past_ { get; set; }

            [ColumnName(@"Consulting experience?")]
            public float[] Consulting_experience_ { get; set; }

            [ColumnName(@"Product or service company?")]
            public float[] Product_or_service_company_ { get; set; }

            [ColumnName(@"Focus on private or public data?")]
            public float[] Focus_on_private_or_public_data_ { get; set; }

            [ColumnName(@"Focus on consumer data?")]
            public float[] Focus_on_consumer_data_ { get; set; }

            [ColumnName(@"Focus on structured or unstructured data")]
            public float[] Focus_on_structured_or_unstructured_data { get; set; }

            [ColumnName(@"Subscription based business")]
            public float[] Subscription_based_business { get; set; }

            [ColumnName(@"Cloud or platform based serive/product?")]
            public float[] Cloud_or_platform_based_serive_product_ { get; set; }

            [ColumnName(@"Local or global player")]
            public float[] Local_or_global_player { get; set; }

            [ColumnName(@"Linear or Non-linear business model")]
            public float[] Linear_or_Non_linear_business_model { get; set; }

            [ColumnName(@"Capital intensive business e.g. e-commerce, Engineering products and operations can also cause a business to be capital intensive")]
            public float[] Capital_intensive_business_e_g__e_commerce__Engineering_products_and_operations_can_also_cause_a_business_to_be_capital_intensive { get; set; }

            [ColumnName(@"Crowdsourcing based business")]
            public float[] Crowdsourcing_based_business { get; set; }

            [ColumnName(@"Crowdfunding based business")]
            public float[] Crowdfunding_based_business { get; set; }

            [ColumnName(@"Machine Learning based business")]
            public float[] Machine_Learning_based_business { get; set; }

            [ColumnName(@"Predictive Analytics business")]
            public float[] Predictive_Analytics_business { get; set; }

            [ColumnName(@"Speech analytics business")]
            public float[] Speech_analytics_business { get; set; }

            [ColumnName(@"Prescriptive analytics business")]
            public float[] Prescriptive_analytics_business { get; set; }

            [ColumnName(@"Big Data Business")]
            public float[] Big_Data_Business { get; set; }

            [ColumnName(@"Cross-Channel Analytics/ marketing channels")]
            public float[] Cross_Channel_Analytics__marketing_channels { get; set; }

            [ColumnName(@"Online or offline venture - physical location based business or online venture?")]
            public float[] Online_or_offline_venture___physical_location_based_business_or_online_venture_ { get; set; }

            [ColumnName(@"Highest education")]
            public float[] Highest_education { get; set; }

            [ColumnName(@"Experience in selling and building products")]
            public float[] Experience_in_selling_and_building_products { get; set; }

            [ColumnName(@"Dificulty of Obtaining Work force")]
            public float[] Dificulty_of_Obtaining_Work_force { get; set; }

            [ColumnName(@"Time to market service or product")]
            public float[] Time_to_market_service_or_product { get; set; }

            [ColumnName(@"Barriers of entry for the competitors")]
            public float[] Barriers_of_entry_for_the_competitors { get; set; }

            [ColumnName(@"Number of Direct competitors")]
            public float Number_of_Direct_competitors { get; set; }

            [ColumnName(@"Last round of funding received (in milionUSD)")]
            public float[] Last_round_of_funding_received__in_milionUSD_ { get; set; }

            [ColumnName(@"Time to 1st investment (in months)")]
            public float Time_to_1st_investment__in_months_ { get; set; }

            [ColumnName(@"Avg time to investment - average across all rounds, measured from previous investment")]
            public float Avg_time_to_investment___average_across_all_rounds__measured_from_previous_investment { get; set; }

            [ColumnName(@"Gartner hype cycle stage")]
            public float[] Gartner_hype_cycle_stage { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("StartupSuccess.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
