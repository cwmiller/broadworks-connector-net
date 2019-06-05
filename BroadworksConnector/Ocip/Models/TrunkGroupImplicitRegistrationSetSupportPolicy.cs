using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupImplicitRegistrationSetSupportPolicy{
    [XmlEnum(Name = "Enabled")]
    Enabled,
    [XmlEnum(Name = "Disabled")]
    Disabled,
 }
}
