using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ChargeIndicator
    {
        [XmlEnum(Name = "Charge")]
        Charge,
        [XmlEnum(Name = "No Charge")]
        NoCharge,
    }
}
