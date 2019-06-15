using System;
using System.Xml.Serialization;
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
     
    public class EnterpriseCallCenterEnhancedReportingScheduledReportGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
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
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> _searchCriteriaCallCenterScheduledReportName;

        [XmlElement(ElementName = "searchCriteriaCallCenterScheduledReportName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterScheduledReportName> SearchCriteriaCallCenterScheduledReportName {
            get => _searchCriteriaCallCenterScheduledReportName;
            set {
                SearchCriteriaCallCenterScheduledReportNameSpecified = true;
                _searchCriteriaCallCenterScheduledReportName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCallCenterScheduledReportNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisor {
            get => _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor;
            set {
                SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisorSpecified = true;
                _searchCriteriaExactCallCenterScheduledReportCreatedBySupervisor = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactCallCenterScheduledReportCreatedBySupervisorSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterReportTemplateKey _searchCriteriaExactCallCenterReportTemplateKey;

        [XmlElement(ElementName = "searchCriteriaExactCallCenterReportTemplateKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactCallCenterReportTemplateKey SearchCriteriaExactCallCenterReportTemplateKey {
            get => _searchCriteriaExactCallCenterReportTemplateKey;
            set {
                SearchCriteriaExactCallCenterReportTemplateKeySpecified = true;
                _searchCriteriaExactCallCenterReportTemplateKey = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactCallCenterReportTemplateKeySpecified { get; set; }
        
    }
}
