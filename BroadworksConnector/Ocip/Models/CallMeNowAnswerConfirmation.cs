using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallMeNowAnswerConfirmation{
    [XmlEnum(Name = "None")]
    None,
    [XmlEnum(Name = "Any Key")]
    AnyKey,
    [XmlEnum(Name = "Passcode")]
    Passcode,
 }
}
