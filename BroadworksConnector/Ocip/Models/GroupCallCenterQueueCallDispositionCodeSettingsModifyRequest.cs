using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterQueueCallDispositionCodeSettingsModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "enableCallDispositionCodes", IsNullable = false)]
    public bool EnableCallDispositionCodes { get; set; }
    [XmlElement(ElementName = "includeOrganizationCodes", IsNullable = false)]
    public bool IncludeOrganizationCodes { get; set; }
    [XmlElement(ElementName = "forceUseOfCallDispositionCodes", IsNullable = false)]
    public bool ForceUseOfCallDispositionCodes { get; set; }
    [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CallDispositionCodeWithLevel DefaultCallDispositionCode { get; set; }
    [XmlElement(ElementName = "callDispositionCodeActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallDispositionCodeActivation> CallDispositionCodeActivation { get; set; }
 }
}
