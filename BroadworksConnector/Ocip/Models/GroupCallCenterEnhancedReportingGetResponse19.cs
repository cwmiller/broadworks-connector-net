using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedReportingGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice19 _reportingServer;

    [XmlElement(ElementName = "reportingServer", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterReportServerChoice19 ReportingServer {
        get => _reportingServer;
        set {
            ReportingServerSpecified = true;
            _reportingServer = value;
        }
    }

    [XmlIgnore]
    public bool ReportingServerSpecified { get; set; }
}
}
