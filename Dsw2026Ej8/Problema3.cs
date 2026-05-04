namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompareCopies(int originalValue, Product product)
        {
            int copy = originalValue;
            copy++;

            Product productCopy = product;
            productCopy.ModifyDescription("New description");

            return $"{originalValue}-{copy}-{product.Description}";
        }
    }
}
