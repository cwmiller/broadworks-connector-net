using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DigitalSignatureAlgorithm{
    [XmlEnum(Name = "MD5")]
    MD5,
 }
}
