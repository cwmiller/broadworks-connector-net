using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum LicenseStrictness{
    [XmlEnum(Name = "Hard")]
    Hard,
    [XmlEnum(Name = "Soft")]
    Soft,
 }
}
