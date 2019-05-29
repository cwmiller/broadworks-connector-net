using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingBrandingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "brandingChoice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingBrandingChoice BrandingChoice { get; set; }
    [XmlElement(ElementName = "brandingFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource BrandingFile { get; set; }
 }
}
