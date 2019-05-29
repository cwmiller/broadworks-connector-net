using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNGetPolicyResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "minExtensionLength", IsNullable = false)]
    public int MinExtensionLength { get; set; }
    [XmlElement(ElementName = "maxExtensionLength", IsNullable = false)]
    public int MaxExtensionLength { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "routeGroupId", IsNullable = false)]
    public string RouteGroupId { get; set; }
    [XmlElement(ElementName = "policySelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection PolicySelection { get; set; }
    [XmlElement(ElementName = "digitManipulation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDigitManipulation> DigitManipulation { get; set; }
    [XmlElement(ElementName = "treatmentId", IsNullable = false)]
    public string TreatmentId { get; set; }
 }
}
