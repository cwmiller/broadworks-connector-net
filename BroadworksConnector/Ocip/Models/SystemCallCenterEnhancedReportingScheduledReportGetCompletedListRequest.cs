using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of all completed call center reporting scheduled reports in the system.
    /// The response is either a SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6286""}]")]
    public class SystemCallCenterEnhancedReportingScheduledReportGetCompletedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingScheduledReportGetCompletedListResponse>
    {

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6286")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> _searchCriteriaCallCenterScheduledReportName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName>();

        [XmlElement(ElementName = "searchCriteriaCallCenterScheduledReportName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6286")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> SearchCriteriaCallCenterScheduledReportName
        {
            get => _searchCriteriaCallCenterScheduledReportName;
            set
            {
                SearchCriteriaCallCenterScheduledReportNameSpecified = true;
                _searchCriteriaCallCenterScheduledReportName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaCallCenterScheduledReportNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId>();

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6286")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId
        {
            get => _searchCriteriaGroupId;
            set
            {
                SearchCriteriaGroupIdSpecified = true;
                _searchCriteriaGroupId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaGroupIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportServiceProvider _searchCriteriaExactCallCenterScheduledReportServiceProvider;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportServiceProvider", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6286")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportServiceProvider SearchCriteriaExactCallCenterScheduledReportServiceProvider
        {
            get => _searchCriteriaExactCallCenterScheduledReportServiceProvider;
            set
            {
                SearchCriteriaExactCallCenterScheduledReportServiceProviderSpecified = true;
                _searchCriteriaExactCallCenterScheduledReportServiceProvider = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactCallCenterScheduledReportServiceProviderSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6286")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId
        {
            get => _searchCriteriaServiceProviderId;
            set
            {
                SearchCriteriaServiceProviderIdSpecified = true;
                _searchCriteriaServiceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceProviderIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6286")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor
        {
            get => _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;
            set
            {
                SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisorSpecified = true;
                _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisorSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterReportTemplateName> _searchCriteriaCallCenterReportTemplateName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterReportTemplateName>();

        [XmlElement(ElementName = "searchCriteriaCallCenterReportTemplateName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6286")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterReportTemplateName> SearchCriteriaCallCenterReportTemplateName
        {
            get => _searchCriteriaCallCenterReportTemplateName;
            set
            {
                SearchCriteriaCallCenterReportTemplateNameSpecified = true;
                _searchCriteriaCallCenterReportTemplateName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaCallCenterReportTemplateNameSpecified { get; set; }

    }
}
