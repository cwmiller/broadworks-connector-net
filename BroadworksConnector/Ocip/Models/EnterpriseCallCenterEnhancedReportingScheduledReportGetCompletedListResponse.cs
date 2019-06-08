using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterEnhancedReportingScheduledReportGetCompletedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _scheduledReportTable;

    [XmlElement(ElementName = "scheduledReportTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ScheduledReportTable {
        get => _scheduledReportTable;
        set {
            ScheduledReportTableSpecified = true;
            _scheduledReportTable = value;
        }
    }

    [XmlIgnore]
    public bool ScheduledReportTableSpecified { get; set; }
}
}
