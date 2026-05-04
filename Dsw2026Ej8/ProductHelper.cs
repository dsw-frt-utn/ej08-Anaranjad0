namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        public string GetProductLabel(long code, string description, decimal price)
        {
            return string.Format(CONSTANTE, code, description, price.ToString("C"));
        }
    }
}
