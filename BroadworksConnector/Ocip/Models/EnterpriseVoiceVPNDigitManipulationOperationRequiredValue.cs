using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Digit Manipulation Operations that have a value.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseVoiceVPNDigitManipulationOperationRequiredValue
    {
        [XmlEnum(Name = "Position")]
        Position,
        [XmlEnum(Name = "Delete")]
        Delete,
        [XmlEnum(Name = "Move")]
        Move,
    }
}
