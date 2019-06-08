using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
