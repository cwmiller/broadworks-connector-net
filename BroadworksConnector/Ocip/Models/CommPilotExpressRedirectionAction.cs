using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CommPilotExpressRedirectionAction{
    [XmlEnum(Name = "Transfer To Voice Mail")]
    TransferToVoiceMail,
    [XmlEnum(Name = "Forward")]
    Forward,
 }
}
