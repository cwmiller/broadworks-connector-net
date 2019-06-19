using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system settings for the call center enhanced reporting scheduling tasks.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6486""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _scheduledReportSearchIntervalMinutes;

        [XmlElement(ElementName = "scheduledReportSearchIntervalMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6486")]
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
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6486")]
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
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6486")]
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
