using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNDigitManipulationNoValue : BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation
{
    [XmlElement(ElementName = "operation", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperationNoValue Operation { get; set; }
 }
}
