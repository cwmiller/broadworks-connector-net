using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NetworkType{
    [XmlEnum(Name = "Private")]
    Private,
    [XmlEnum(Name = "Public")]
    Public,
 }
}
