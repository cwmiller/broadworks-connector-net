using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22
    /// 
    /// The following elements are only used in AS data mode:
    /// callCenterEventMode, value “Legacy ECCR" is returned in Amplify data mode
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6433""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _scheduledReportSearchIntervalMinutes;

        [XmlElement(ElementName = "scheduledReportSearchIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6433")]
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
        protected bool ScheduledReportSearchIntervalMinutesSpecified { get; set; }

        private int _maximumScheduledReportsPerInterval;

        [XmlElement(ElementName = "maximumScheduledReportsPerInterval", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6433")]
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
        protected bool MaximumScheduledReportsPerIntervalSpecified { get; set; }

        private int _deleteScheduledReportDaysAfterCompletion;

        [XmlElement(ElementName = "deleteScheduledReportDaysAfterCompletion", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6433")]
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
        protected bool DeleteScheduledReportDaysAfterCompletionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallCenterEventRecordingCallCenterEventMode _callCenterEventMode;

        [XmlElement(ElementName = "callCenterEventMode", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:6433")]
        public BroadWorksConnector.Ocip.Models.CallCenterEventRecordingCallCenterEventMode CallCenterEventMode
        {
            get => _callCenterEventMode;
            set
            {
                CallCenterEventModeSpecified = true;
                _callCenterEventMode = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterEventModeSpecified { get; set; }

    }
}
