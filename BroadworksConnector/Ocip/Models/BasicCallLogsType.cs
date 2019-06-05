using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BasicCallLogsType
    {
        [XmlEnum(Name = "Placed")]
        Placed,
        [XmlEnum(Name = "Received")]
        Received,
        [XmlEnum(Name = "Missed")]
        Missed,
    }
}
