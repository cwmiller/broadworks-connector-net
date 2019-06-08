using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterOverflowProcessingAction{
    [XmlEnum(Name = "Busy")]
    Busy,
    [XmlEnum(Name = "Transfer")]
    Transfer,
    [XmlEnum(Name = "Ringing")]
    Ringing,
 }
}
