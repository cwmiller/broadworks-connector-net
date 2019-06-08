using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum IntegratedIMPUserIDType{
    [XmlEnum(Name = "Primary")]
    Primary,
    [XmlEnum(Name = "Alternate")]
    Alternate,
 }
}
