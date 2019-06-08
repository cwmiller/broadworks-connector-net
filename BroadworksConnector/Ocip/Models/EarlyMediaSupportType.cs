using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EarlyMediaSupportType{
    [XmlEnum(Name = "No Early Media")]
    NoEarlyMedia,
    [XmlEnum(Name = "RTP - Session")]
    RTPSession,
    [XmlEnum(Name = "RTP - Early Session")]
    RTPEarlySession,
 }
}
