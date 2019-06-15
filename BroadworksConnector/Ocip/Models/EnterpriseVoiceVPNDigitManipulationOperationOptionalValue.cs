using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Digit Manipulation Operations that may or may not have a value.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseVoiceVPNDigitManipulationOperationOptionalValue    {
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
