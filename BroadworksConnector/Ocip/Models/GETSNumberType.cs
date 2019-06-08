using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GETSNumberType{
    [XmlEnum(Name = "AN")]
    AN,
    [XmlEnum(Name = "NT")]
    NT,
 }
}
