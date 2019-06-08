using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingScheduledReportGetReportTemplateUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _scheduleReportTable;

    [XmlElement(ElementName = "scheduleReportTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ScheduleReportTable {
        get => _scheduleReportTable;
        set {
            ScheduleReportTableSpecified = true;
            _scheduleReportTable = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleReportTableSpecified { get; set; }
}
}
