namespace FreeAgent.Models
{

    public class SalesTaxRates
    {
        public SalesTaxRate[] sales_tax_rates { get; set; }
        public string ec_tax_name { get; set; }
    }

    public class SalesTaxRate
    {
        public string percentage { get; set; }
        public string band { get; set; }
    }


}
