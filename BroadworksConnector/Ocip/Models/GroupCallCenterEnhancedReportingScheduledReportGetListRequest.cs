using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingScheduledReportGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaCallCenterScheduledReportName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> SearchCriteriaCallCenterScheduledReportName { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactCallCenterReportTemplateKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterReportTemplateKey SearchCriteriaExactCallCenterReportTemplateKey { get; set; }
 }
}
