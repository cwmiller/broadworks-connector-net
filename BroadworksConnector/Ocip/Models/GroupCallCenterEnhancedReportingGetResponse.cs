using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterEnhancedReportingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.CallCenterReportServerChoice _reportingServer;

        [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportServerChoice ReportingServer
        {
            get => _reportingServer;
            set
            {
                ReportingServerSpecified = true;
                _reportingServer = value;
            }
        }

        [XmlIgnore]
        public bool ReportingServerSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportWebStatisticsSource _webStatisticSource;

        [XmlElement(ElementName = "webStatisticSource", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportWebStatisticsSource WebStatisticSource
        {
            get => _webStatisticSource;
            set
            {
                WebStatisticSourceSpecified = true;
                _webStatisticSource = value;
            }
        }

        [XmlIgnore]
        public bool WebStatisticSourceSpecified { get; set; }
    }
}
