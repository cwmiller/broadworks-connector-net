using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SystemSIPSupportedInterface{
    [XmlEnum(Name = "Access")]
    Access,
    [XmlEnum(Name = "Network")]
    Network,
    [XmlEnum(Name = "Both")]
    Both,
 }
}
