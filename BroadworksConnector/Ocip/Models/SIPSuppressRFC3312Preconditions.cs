using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPSuppressRFC3312Preconditions{
    [XmlEnum(Name = "Always")]
    Always,
    [XmlEnum(Name = "Never")]
    Never,
    [XmlEnum(Name = "Suppress If Single Dialog")]
    SuppressIfSingleDialog,
 }
}
