using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The type of outbound calls to block or allow.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum InterceptOutboundCall    {
            [XmlEnum(Name = "Block All")]
        BlockAll,
            [XmlEnum(Name = "Allow Outbound Local Calls")]
        AllowOutboundLocalCalls,
            [XmlEnum(Name = "Allow Outbound Enterprise And Group Calls")]
        AllowOutboundEnterpriseAndGroupCalls,
     }
}
