using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Possible values for Charge Indicator.
    /// </summary>
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
