using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of completed group level call center reporting scheduled reports.
    /// The response is either a GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse or an ErrorResponse.
    /// <see cref="GroupCallCenterEnhancedReportingScheduledReportGetCompletedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:3688""}]")]
    public class GroupCallCenterEnhancedReportingScheduledReportGetCompletedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3688")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3688")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3688")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> _searchCriteriaCallCenterScheduledReportName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName>();

        [XmlElement(ElementName = "searchCriteriaCallCenterScheduledReportName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3688")]
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

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3688")]
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

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterReportTemplateKey _searchCriteriaExactCallCenterReportTemplateKey;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterReportTemplateKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:3688")]
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
