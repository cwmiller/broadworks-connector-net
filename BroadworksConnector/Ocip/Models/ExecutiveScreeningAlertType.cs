using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ExecutiveScreeningAlertType{
    [XmlEnum(Name = "Silent")]
    Silent,
    [XmlEnum(Name = "Ring Splash")]
    RingSplash,
 }
}
