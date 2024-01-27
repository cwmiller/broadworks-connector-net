using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterEnhancedReportingGetRequest.
    /// 
    /// Replaced by EnterpriseCallCenterEnhancedReportingGetResponse19
    /// <see cref="EnterpriseCallCenterEnhancedReportingGetRequest"/>
    /// <see cref="EnterpriseCallCenterEnhancedReportingGetResponse19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:2213""}]")]
    public class EnterpriseCallCenterEnhancedReportingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:2213")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterReportWebStatisticsSource _webStatisticSource;

        [XmlElement(ElementName = "webStatisticSource", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:2213")]
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
