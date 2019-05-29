using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCallCenterReportTemplateKey : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "reportTemplate", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterReportTemplateKey ReportTemplate { get; set; }
 }
}
