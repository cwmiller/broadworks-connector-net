using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DTMFTransmissionMethod{
    [XmlEnum(Name = "Signaling")]
    Signaling,
    [XmlEnum(Name = "RTP")]
    RTP,
 }
}
