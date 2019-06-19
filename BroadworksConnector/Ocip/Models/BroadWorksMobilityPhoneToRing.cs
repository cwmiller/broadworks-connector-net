using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// BroadWorks Mobility interrupt type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BroadWorksMobilityPhoneToRing
    {
        [XmlEnum(Name = "Fixed")]
        Fixed,
        [XmlEnum(Name = "Mobile")]
        Mobile,
        [XmlEnum(Name = "Both")]
        Both,
    }
}
