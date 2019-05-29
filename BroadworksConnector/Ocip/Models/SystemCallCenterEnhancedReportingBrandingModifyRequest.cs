using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingBrandingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "brandingChoice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice BrandingChoice { get; set; }
    [XmlElement(ElementName = "customBrandingFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource CustomBrandingFile { get; set; }
 }
}
