using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device Category
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceCategory
    {
        [XmlEnum(Name = "Generic")]
        Generic,
        [XmlEnum(Name = "Hosted")]
        Hosted,
        [XmlEnum(Name = "Client Applications")]
        ClientApplications,
        [XmlEnum(Name = "SIP Trunking")]
        SIPTrunking,
        [XmlEnum(Name = "Local Gateway")]
        LocalGateway,
    }
}
