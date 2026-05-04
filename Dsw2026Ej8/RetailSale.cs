namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Amount;
        }
    }
}
