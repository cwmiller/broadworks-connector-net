using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseVoiceVPNModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "defaultSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNDefaultSelection DefaultSelection { get; set; }
    [XmlElement(ElementName = "e164Selection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNNonMatchingE164NumberSelection E164Selection { get; set; }
    [XmlElement(ElementName = "usePhoneContext", IsNullable = false)]
    public bool UsePhoneContext { get; set; }
 }
}
