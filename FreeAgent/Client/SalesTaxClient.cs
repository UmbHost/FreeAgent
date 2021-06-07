using System;
using System.Net;
using FreeAgent.Exceptions;
using FreeAgent.Models;
using RestSharp;

namespace FreeAgent.Client
{
    public class SalesTaxClient : BaseClient
    {
        public SalesTaxClient(FreeAgentClient client) : base(client)
        {
        }

        public override string ResouceName { get { return "ec_moss"; } }

        public SalesTaxRates GetSalesTaxRates(string country, DateTime date)
        {
            try
            {
                var request = CreateGetRequest(country, date);
                var response = Client.Execute<SalesTaxRates>(request);

                if (response != null) return response;

                return null;
            }
            catch (FreeAgentException fex)
            {
                if (fex.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        protected RestRequest CreateGetRequest(string country, DateTime date)
        {
            var request = CreateBasicRequest(Method.GET, "/sales_tax_rates");
            request.AddParameter("country", country, ParameterType.QueryString);
            request.AddParameter("date", date.ToString("yyyy-MM-dd"), ParameterType.QueryString);

            return request;
        }
    }
}
