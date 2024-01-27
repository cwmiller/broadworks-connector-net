using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of enterprise level call center reporting scheduled reports.
    /// The response is either an EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse or an ErrorResponse.
    /// <see cref="EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:1638""}]")]
    public class EnterpriseCallCenterEnhancedReportingScheduledReportGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseCallCenterEnhancedReportingScheduledReportGetListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1638")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1638")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:1638")]
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

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1638")]
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

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterReportTemplateKey _searchCriteriaExactCallCenterReportTemplateKey;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterReportTemplateKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:1638")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterReportTemplateKey SearchCriteriaExactCallCenterReportTemplateKey
        {
            get => _searchCriteriaExactCallCenterReportTemplateKey;
            set
            {
                SearchCriteriaExactCallCenterReportTemplateKeySpecified = true;
                _searchCriteriaExactCallCenterReportTemplateKey = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactCallCenterReportTemplateKeySpecified { get; set; }

    }
}
