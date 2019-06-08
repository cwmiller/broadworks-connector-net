using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterEnhancedReportingScheduledTaskParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _scheduledReportSearchIntervalMinutes;

    [XmlElement(ElementName = "scheduledReportSearchIntervalMinutes", IsNullable = false, Namespace = "")]
    public int ScheduledReportSearchIntervalMinutes {
        get => _scheduledReportSearchIntervalMinutes;
        set {
            ScheduledReportSearchIntervalMinutesSpecified = true;
            _scheduledReportSearchIntervalMinutes = value;
        }
    }

    [XmlIgnore]
    public bool ScheduledReportSearchIntervalMinutesSpecified { get; set; }
    private int _maximumScheduledReportsPerInterval;

    [XmlElement(ElementName = "maximumScheduledReportsPerInterval", IsNullable = false, Namespace = "")]
    public int MaximumScheduledReportsPerInterval {
        get => _maximumScheduledReportsPerInterval;
        set {
            MaximumScheduledReportsPerIntervalSpecified = true;
            _maximumScheduledReportsPerInterval = value;
        }
    }

    [XmlIgnore]
    public bool MaximumScheduledReportsPerIntervalSpecified { get; set; }
    private int _deleteScheduledReportDaysAfterCompletion;

    [XmlElement(ElementName = "deleteScheduledReportDaysAfterCompletion", IsNullable = false, Namespace = "")]
    public int DeleteScheduledReportDaysAfterCompletion {
        get => _deleteScheduledReportDaysAfterCompletion;
        set {
            DeleteScheduledReportDaysAfterCompletionSpecified = true;
            _deleteScheduledReportDaysAfterCompletion = value;
        }
    }

    [XmlIgnore]
    public bool DeleteScheduledReportDaysAfterCompletionSpecified { get; set; }
}
}
