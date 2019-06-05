using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AdviceOfChargeIncomingAocHandling
    {
        [XmlEnum(Name = "Ignore")]
        Ignore,
        [XmlEnum(Name = "Charge")]
        Charge,
    }
}
