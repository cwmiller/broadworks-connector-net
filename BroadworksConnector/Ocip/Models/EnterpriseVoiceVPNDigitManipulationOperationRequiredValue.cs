using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
