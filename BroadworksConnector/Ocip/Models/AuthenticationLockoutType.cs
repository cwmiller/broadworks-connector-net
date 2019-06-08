using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AuthenticationLockoutType{
    [XmlEnum(Name = "None")]
    None,
    [XmlEnum(Name = "Temporary")]
    Temporary,
    [XmlEnum(Name = "Temporary Then Permanent")]
    TemporaryThenPermanent,
 }
}
