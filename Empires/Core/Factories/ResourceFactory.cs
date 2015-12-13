namespace Empires.Core.Factories
{
    using System;
    using Interfaces;
    using Models.Resources;
    using Utils;

    public class ResourceFactory
    {
        public static IResource Produce(string resourceType, int resourceQuantity)
        {
            switch (resourceType)
            {
                case "Gold":
                    return new Resource(ResourceType.Gold, resourceQuantity);
                case "Steel":
                    return new Resource(ResourceType.Steel, resourceQuantity);
                default:
                    throw new InvalidOperationException(
                        string.Format(EmpireConstants.NotExistingObj, "Resource"));
            }
        }
    }
}