using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The basic call type for the origination
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BasicCallType    {
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "Enterprise")]
        Enterprise,
            [XmlEnum(Name = "Network")]
        Network,
            [XmlEnum(Name = "Network URL")]
        NetworkURL,
            [XmlEnum(Name = "Repair")]
        Repair,
            [XmlEnum(Name = "Emergency")]
        Emergency,
     }
}
