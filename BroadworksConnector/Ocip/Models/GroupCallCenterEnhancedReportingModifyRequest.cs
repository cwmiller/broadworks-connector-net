using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
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
