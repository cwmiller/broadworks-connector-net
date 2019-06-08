using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AuthenticationLockoutWaitAlgorithmType{
    [XmlEnum(Name = "Double")]
    Double,
    [XmlEnum(Name = "Fixed")]
    Fixed,
 }
}
