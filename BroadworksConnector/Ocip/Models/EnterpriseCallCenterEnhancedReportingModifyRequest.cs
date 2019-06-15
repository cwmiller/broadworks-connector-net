using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify enterprise level call center enhanced reporting settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by EnterpriseCallCenterEnhancedReportingModifyRequest19
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="EnterpriseCallCenterEnhancedReportingModifyRequest19"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCallCenterEnhancedReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice ReportingServer {
            get => _reportingServer;
            set {
                ReportingServerSpecified = true;
                _reportingServer = value;
            }
        }

        [XmlIgnore]
        public bool ReportingServerSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportWebStatisticsSource _webStatisticSource;

        [XmlElement(ElementName = "webStatisticSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportWebStatisticsSource WebStatisticSource {
            get => _webStatisticSource;
            set {
                WebStatisticSourceSpecified = true;
                _webStatisticSource = value;
            }
        }

        [XmlIgnore]
        public bool WebStatisticSourceSpecified { get; set; }
        
    }
}
