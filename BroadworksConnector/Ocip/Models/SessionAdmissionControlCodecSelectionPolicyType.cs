using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SessionAdmissionControlCodecSelectionPolicyType{
    [XmlEnum(Name = "Highest Weight")]
    HighestWeight,
    [XmlEnum(Name = "Preferred Codec")]
    PreferredCodec,
 }
}
