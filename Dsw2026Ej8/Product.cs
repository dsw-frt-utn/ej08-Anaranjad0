namespace Dsw2026Ej8
{
    public class Product
    {
        public string Description { get; private set; }

        public Product (string description)
        {
            Description = description;
        }

        public void ModifyDescription(string newDescription)
        {
            if (string.IsNullOrWhiteSpace(newDescription))
            {
                throw new ArgumentException("La descripción no puede ser vacía o nula.");
            }
            Description = newDescription;
        }
    }
}
