using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNGetDefaultResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "policySelection", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection> PolicySelection { get; set; }
    [XmlElement(ElementName = "digitManipulationOperation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulationOperation> DigitManipulationOperation { get; set; }
    [XmlElement(ElementName = "routeGroupId", IsNullable = false)]
    public List<string> RouteGroupId { get; set; }
    [XmlElement(ElementName = "treatment", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNTreatmentEntry> Treatment { get; set; }
 }
}
