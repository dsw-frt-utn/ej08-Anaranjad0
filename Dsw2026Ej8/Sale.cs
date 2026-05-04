using System;
namespace Dsw2026Ej8
{
    internal class Sale
    {
        public decimal Amount { get; set; }
        public virtual decimal CalculateTotal()
        {
            return Amount;
        }
    }
}
