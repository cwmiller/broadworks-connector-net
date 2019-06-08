using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EnterpriseInternalCallsCLIDPolicy{
    [XmlEnum(Name = "Use Extension")]
    UseExtension,
    [XmlEnum(Name = "Use Location Code plus Extension")]
    UseLocationCodeplusExtension,
    [XmlEnum(Name = "Use External Calls Policy")]
    UseExternalCallsPolicy,
 }
}
