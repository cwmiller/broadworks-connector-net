using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNDigitManipulationOptionalValue : BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
{
    [XmlElement(ElementName = "operation", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationOptionalValue Operation { get; set; }
    [XmlElement(ElementName = "value", IsNullable = true)]
    public string Value { get; set; }
 }
}
