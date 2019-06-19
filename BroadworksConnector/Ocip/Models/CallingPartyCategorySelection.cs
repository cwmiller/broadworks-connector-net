using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Calling Party Category Selection
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallingPartyCategorySelection
    {
        [XmlEnum(Name = "Special")]
        Special,
        [XmlEnum(Name = "Hospital")]
        Hospital,
        [XmlEnum(Name = "Hotel")]
        Hotel,
        [XmlEnum(Name = "Prison")]
        Prison,
        [XmlEnum(Name = "Payphone")]
        Payphone,
        [XmlEnum(Name = "Ordinary")]
        Ordinary,
    }
}
