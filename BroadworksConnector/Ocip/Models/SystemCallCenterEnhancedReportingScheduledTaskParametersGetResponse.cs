using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduledReportSearchIntervalMinutes", IsNullable = false)]
    public int ScheduledReportSearchIntervalMinutes { get; set; }
    [XmlElement(ElementName = "maximumScheduledReportsPerInterval", IsNullable = false)]
    public int MaximumScheduledReportsPerInterval { get; set; }
    [XmlElement(ElementName = "deleteScheduledReportDaysAfterCompletion", IsNullable = false)]
    public int DeleteScheduledReportDaysAfterCompletion { get; set; }
 }
}
