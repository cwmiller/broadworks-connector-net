using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNDigitManipulationRequiredValue : BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
{
    [XmlElement(ElementName = "operation", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationRequiredValue Operation { get; set; }
    [XmlElement(ElementName = "value", IsNullable = false)]
    public string Value { get; set; }
 }
}
