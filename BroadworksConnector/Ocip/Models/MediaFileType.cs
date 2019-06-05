using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MediaFileType{
    [XmlEnum(Name = "WMA")]
    WMA,
    [XmlEnum(Name = "WAV")]
    WAV,
    [XmlEnum(Name = "3GP")]
    _3GP,
    [XmlEnum(Name = "MOV")]
    MOV,
 }
}
