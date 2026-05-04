namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public  string CreateSalesSummary (long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = quantity <= 0 ? 0 : quantity * unitPrice;

            var summary = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            return $"{summary.Code} - {summary.Description} - {summary.Total:C}";
        }
    }
};
