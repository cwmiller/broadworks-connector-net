using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EmergencyZonesProhibition{
    [XmlEnum(Name = "Prohibit all registrations and call originations")]
    Prohibitallregistrationsandcalloriginations,
    [XmlEnum(Name = "Prohibit emergency call originations")]
    Prohibitemergencycalloriginations,
 }
}
