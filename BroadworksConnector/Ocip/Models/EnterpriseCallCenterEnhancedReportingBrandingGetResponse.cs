using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingBrandingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "brandingChoice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterEnhancedReportingBrandingChoice BrandingChoice { get; set; }
    [XmlElement(ElementName = "brandingFileDescription", IsNullable = false)]
    public string BrandingFileDescription { get; set; }
 }
}
