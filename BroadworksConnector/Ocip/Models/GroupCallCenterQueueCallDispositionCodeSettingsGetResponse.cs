using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterQueueCallDispositionCodeSettingsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableCallDispositionCodes", IsNullable = false)]
    public bool EnableCallDispositionCodes { get; set; }
    [XmlElement(ElementName = "includeOrganizationCodes", IsNullable = false)]
    public bool IncludeOrganizationCodes { get; set; }
    [XmlElement(ElementName = "forceUseOfCallDispositionCodes", IsNullable = false)]
    public bool ForceUseOfCallDispositionCodes { get; set; }
    [XmlElement(ElementName = "defaultCallDispositionCode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallDispositionCodeWithLevel DefaultCallDispositionCode { get; set; }
 }
}
