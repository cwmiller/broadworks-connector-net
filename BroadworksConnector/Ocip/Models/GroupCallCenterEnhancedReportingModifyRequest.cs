using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify group level call center enhanced reporting settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by GroupCallCenterEnhancedReportingModifyRequest19
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterEnhancedReportingModifyRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4913""}]")]
    public class GroupCallCenterEnhancedReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4913")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4913")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4913")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice ReportingServer
        {
            get => _reportingServer;
            set
            {
                ReportingServerSpecified = true;
                _reportingServer = value;
            }
        }

        [XmlIgnore]
        protected bool ReportingServerSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterReportWebStatisticsSource _webStatisticSource;

        [XmlElement(ElementName = "webStatisticSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:4913")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportWebStatisticsSource WebStatisticSource
        {
            get => _webStatisticSource;
            set
            {
                WebStatisticSourceSpecified = true;
                _webStatisticSource = value;
            }
        }

        [XmlIgnore]
        protected bool WebStatisticSourceSpecified { get; set; }

    }
}
