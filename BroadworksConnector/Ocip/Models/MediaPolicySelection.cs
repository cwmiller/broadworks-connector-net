using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MediaPolicySelection{
    [XmlEnum(Name = "Use Uncompressed Codec")]
    UseUncompressedCodec,
    [XmlEnum(Name = "Use Supported Media Set")]
    UseSupportedMediaSet,
    [XmlEnum(Name = "No Restrictions")]
    NoRestrictions,
 }
}
