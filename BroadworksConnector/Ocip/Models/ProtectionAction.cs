using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ProtectionAction{
    [XmlEnum(Name = "Decline")]
    Decline,
    [XmlEnum(Name = "Drop")]
    Drop,
    [XmlEnum(Name = "Error")]
    Error,
    [XmlEnum(Name = "Redirect")]
    Redirect,
    [XmlEnum(Name = "Unavailable")]
    Unavailable,
 }
}
