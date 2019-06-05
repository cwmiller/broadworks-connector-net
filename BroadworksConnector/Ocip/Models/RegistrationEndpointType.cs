using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RegistrationEndpointType{
    [XmlEnum(Name = "Primary")]
    Primary,
    [XmlEnum(Name = "Shared Call Appearance")]
    SharedCallAppearance,
    [XmlEnum(Name = "Video Add On")]
    VideoAddOn,
 }
}
