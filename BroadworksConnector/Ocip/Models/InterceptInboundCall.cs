using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The type of inbound calls to Intercept or allow.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum InterceptInboundCall    {
            [XmlEnum(Name = "Intercept All")]
        InterceptAll,
            [XmlEnum(Name = "Allow All")]
        AllowAll,
            [XmlEnum(Name = "Allow System Dns")]
        AllowSystemDns,
     }
}
