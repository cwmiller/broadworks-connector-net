using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
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
