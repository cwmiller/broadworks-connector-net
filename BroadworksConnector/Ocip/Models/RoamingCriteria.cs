using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RoamingCriteria{
    [XmlEnum(Name = "In Home Network")]
    InHomeNetwork,
    [XmlEnum(Name = "In Roaming Network")]
    InRoamingNetwork,
    [XmlEnum(Name = "Disregard Roaming")]
    DisregardRoaming,
 }
}
