using System.Runtime.Serialization;

namespace PlantsLib
{
    public class Plant
    {
        [DataMember(Name = "Вид")]
        public string Species { get; set; }

        [DataMember(Name = "Частота полива")]
        public double WateringFrequency { get; set; }
    }
}