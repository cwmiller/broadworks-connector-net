using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call Log type used by enhanced call logs requests
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnhancedCallLogsCallLogsRequestType    {
            [XmlEnum(Name = "Placed")]
        Placed,
            [XmlEnum(Name = "Received")]
        Received,
            [XmlEnum(Name = "Missed")]
        Missed,
            [XmlEnum(Name = "ReceivedOrMissed")]
        ReceivedOrMissed,
     }
}
