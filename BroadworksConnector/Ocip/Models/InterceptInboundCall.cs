using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum InterceptInboundCall{
    [XmlEnum(Name = "Intercept All")]
    InterceptAll,
    [XmlEnum(Name = "Allow All")]
    AllowAll,
    [XmlEnum(Name = "Allow System Dns")]
    AllowSystemDns,
 }
}
