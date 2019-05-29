using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingScheduledReportGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaCallCenterScheduledReportName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> SearchCriteriaCallCenterScheduledReportName { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportServiceProvider", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportServiceProvider SearchCriteriaExactCallCenterScheduledReportServiceProvider { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor { get; set; }
    [XmlElement(ElementName = "searchCriteriaCallCenterReportTemplateName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterReportTemplateName> SearchCriteriaCallCenterReportTemplateName { get; set; }
 }
}
