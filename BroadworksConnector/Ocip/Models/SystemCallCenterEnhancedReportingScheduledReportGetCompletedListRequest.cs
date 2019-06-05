using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingScheduledReportGetCompletedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _responseSizeLimit;

    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
    public int ResponseSizeLimit {
        get => _responseSizeLimit;
        set {
            ResponseSizeLimitSpecified = true;
            _responseSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool ResponseSizeLimitSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> _searchCriteriaCallCenterScheduledReportName;

    [XmlElement(ElementName = "searchCriteriaCallCenterScheduledReportName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> SearchCriteriaCallCenterScheduledReportName {
        get => _searchCriteriaCallCenterScheduledReportName;
        set {
            SearchCriteriaCallCenterScheduledReportNameSpecified = true;
            _searchCriteriaCallCenterScheduledReportName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaCallCenterScheduledReportNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
        get => _searchCriteriaGroupId;
        set {
            SearchCriteriaGroupIdSpecified = true;
            _searchCriteriaGroupId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportServiceProvider _searchCriteriaExactCallCenterScheduledReportServiceProvider;

    [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportServiceProvider", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportServiceProvider SearchCriteriaExactCallCenterScheduledReportServiceProvider {
        get => _searchCriteriaExactCallCenterScheduledReportServiceProvider;
        set {
            SearchCriteriaExactCallCenterScheduledReportServiceProviderSpecified = true;
            _searchCriteriaExactCallCenterScheduledReportServiceProvider = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactCallCenterScheduledReportServiceProviderSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId;

    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId {
        get => _searchCriteriaServiceProviderId;
        set {
            SearchCriteriaServiceProviderIdSpecified = true;
            _searchCriteriaServiceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceProviderIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;

    [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor {
        get => _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;
        set {
            SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisorSpecified = true;
            _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisorSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterReportTemplateName> _searchCriteriaCallCenterReportTemplateName;

    [XmlElement(ElementName = "searchCriteriaCallCenterReportTemplateName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterReportTemplateName> SearchCriteriaCallCenterReportTemplateName {
        get => _searchCriteriaCallCenterReportTemplateName;
        set {
            SearchCriteriaCallCenterReportTemplateNameSpecified = true;
            _searchCriteriaCallCenterReportTemplateName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaCallCenterReportTemplateNameSpecified { get; set; }
}
}
