using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EnterpriseVoiceVPNDigitManipulationOperationOptionalValue{
    [XmlEnum(Name = "Prepend")]
    Prepend,
    [XmlEnum(Name = "Overwrite")]
    Overwrite,
    [XmlEnum(Name = "Right Trim")]
    RightTrim,
    [XmlEnum(Name = "Replace All")]
    ReplaceAll,
    [XmlEnum(Name = "Left Trim")]
    LeftTrim,
    [XmlEnum(Name = "Append")]
    Append,
    [XmlEnum(Name = "Insert")]
    Insert,
    [XmlEnum(Name = "Trim")]
    Trim,
 }
}
