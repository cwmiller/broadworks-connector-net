using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SIPDestinationTrunkGroupFormat{
    [XmlEnum(Name = "DTG")]
    DTG,
    [XmlEnum(Name = "Tgrp In Contact")]
    TgrpInContact,
    [XmlEnum(Name = "Tgrp In Request URI")]
    TgrpInRequestURI,
    [XmlEnum(Name = "X Nortel Profile")]
    XNortelProfile,
 }
}
