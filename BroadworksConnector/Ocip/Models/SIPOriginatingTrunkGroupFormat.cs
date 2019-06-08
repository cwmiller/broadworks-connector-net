using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPOriginatingTrunkGroupFormat{
    [XmlEnum(Name = "OTG")]
    OTG,
    [XmlEnum(Name = "X Nortel Profile")]
    XNortelProfile,
 }
}
