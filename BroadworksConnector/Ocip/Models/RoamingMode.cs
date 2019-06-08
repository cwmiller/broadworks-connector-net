using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RoamingMode{
    [XmlEnum(Name = "CDMA")]
    CDMA,
    [XmlEnum(Name = "GSM")]
    GSM,
    [XmlEnum(Name = "None")]
    None,
 }
}
