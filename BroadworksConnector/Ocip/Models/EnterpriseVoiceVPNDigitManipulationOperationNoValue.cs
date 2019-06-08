using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EnterpriseVoiceVPNDigitManipulationOperationNoValue{
    [XmlEnum(Name = "End")]
    End,
 }
}
