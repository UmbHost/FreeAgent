namespace FreeAgent.Models
{
    public class PdfInvoice
    {
        public Pdf pdf { get; set; }
    }

    public class Pdf
    {
        public string content { get; set; }
    }
}