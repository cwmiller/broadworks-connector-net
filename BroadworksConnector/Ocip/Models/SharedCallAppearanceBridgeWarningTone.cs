using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SharedCallAppearanceBridgeWarningTone{
    [XmlEnum(Name = "None")]
    None,
    [XmlEnum(Name = "Barge-In")]
    BargeIn,
    [XmlEnum(Name = "Barge-In and Repeat")]
    BargeInandRepeat,
 }
}
