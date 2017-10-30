using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: CLSCompliant(true)]

namespace AttributedCarLibrary
{
    #region Custom attribute!
    // A custom attribute.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,AllowMultiple = false, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }

        public VehicleDescriptionAttribute(string vehicalDescription) 
            => Description = vehicalDescription;
        public VehicleDescriptionAttribute() { }
    }
    #endregion

    // Assign description using a "named property."
    [Serializable]
    [VehicleDescription(Description = "My rocking Harley")]
    public class Motorcycle
    {
    }

    [SerializableAttribute]
    [ObsoleteAttribute("Use another vehicle!")]
    [VehicleDescription("The old gray mare, she ain't what she used to be...")]
    public class HorseAndBuggy
    {
    }

    [VehicleDescription("A very long, slow, but feature-rich auto")]
    public class Winnebago
    {
    }
}
