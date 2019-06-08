using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SessionAdmissionControlForMusicOnHoldType{
    [XmlEnum(Name = "Do Not Play")]
    DoNotPlay,
    [XmlEnum(Name = "Play And Count")]
    PlayAndCount,
 }
}
