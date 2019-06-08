using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPPrivacyVersion{
    [XmlEnum(Name = "RFC3323")]
    RFC3323,
    [XmlEnum(Name = "RFC3323 Japan")]
    RFC3323Japan,
    [XmlEnum(Name = "Privacy 03")]
    Privacy03,
    [XmlEnum(Name = "Privacy 00")]
    Privacy00,
 }
}
