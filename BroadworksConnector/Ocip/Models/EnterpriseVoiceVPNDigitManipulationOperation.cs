using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EnterpriseVoiceVPNDigitManipulationOperation{
    [XmlEnum(Name = "Prepend")]
    Prepend,
    [XmlEnum(Name = "End")]
    End,
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
    [XmlEnum(Name = "Position")]
    Position,
    [XmlEnum(Name = "Insert")]
    Insert,
    [XmlEnum(Name = "Trim")]
    Trim,
    [XmlEnum(Name = "Delete")]
    Delete,
    [XmlEnum(Name = "Move")]
    Move,
 }
}
