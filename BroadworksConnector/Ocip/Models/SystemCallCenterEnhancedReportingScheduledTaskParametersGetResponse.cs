using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6468""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _scheduledReportSearchIntervalMinutes;

        [XmlElement(ElementName = "scheduledReportSearchIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6468")]
        [MinInclusive(1)]
        [MaxInclusive(1440)]
        public int ScheduledReportSearchIntervalMinutes
        {
            get => _scheduledReportSearchIntervalMinutes;
            set
            {
                ScheduledReportSearchIntervalMinutesSpecified = true;
                _scheduledReportSearchIntervalMinutes = value;
            }
        }

        [XmlIgnore]
        public bool ScheduledReportSearchIntervalMinutesSpecified { get; set; }

        private int _maximumScheduledReportsPerInterval;

        [XmlElement(ElementName = "maximumScheduledReportsPerInterval", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6468")]
        [MinInclusive(1)]
        [MaxInclusive(100000)]
        public int MaximumScheduledReportsPerInterval
        {
            get => _maximumScheduledReportsPerInterval;
            set
            {
                MaximumScheduledReportsPerIntervalSpecified = true;
                _maximumScheduledReportsPerInterval = value;
            }
        }

        [XmlIgnore]
        public bool MaximumScheduledReportsPerIntervalSpecified { get; set; }

        private int _deleteScheduledReportDaysAfterCompletion;

        [XmlElement(ElementName = "deleteScheduledReportDaysAfterCompletion", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6468")]
        [MinInclusive(1)]
        [MaxInclusive(366)]
        public int DeleteScheduledReportDaysAfterCompletion
        {
            get => _deleteScheduledReportDaysAfterCompletion;
            set
            {
                DeleteScheduledReportDaysAfterCompletionSpecified = true;
                _deleteScheduledReportDaysAfterCompletion = value;
            }
        }

        [XmlIgnore]
        public bool DeleteScheduledReportDaysAfterCompletionSpecified { get; set; }

    }
}
