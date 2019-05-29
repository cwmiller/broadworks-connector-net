using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingBrandingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "brandingChoice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingSystemBrandingChoice BrandingChoice { get; set; }
    [XmlElement(ElementName = "customBrandingFileDescription", IsNullable = false)]
    public string CustomBrandingFileDescription { get; set; }
 }
}
