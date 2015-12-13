namespace Empires.Models.Resources
{
    using Core.Utils;
    using Interfaces;

    public class Resource : IResource
    {
        private int quantity;

        public Resource(ResourceType type, int quantity)
        {
            this.Type = type;
            this.Quantity = quantity;
        }

        public ResourceType Type { get; set; }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                Validator.IsBiggerThan(value, 0, "Resource quantity");
                this.quantity = value;
            }
        }
    }
}