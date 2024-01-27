using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22.
    /// 
    /// Replaced by: SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse25.
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest22"/>
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21480""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _scheduledReportSearchIntervalMinutes;

        [XmlElement(ElementName = "scheduledReportSearchIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21480")]
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

        protected int _maximumScheduledReportsPerInterval;

        [XmlElement(ElementName = "maximumScheduledReportsPerInterval", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21480")]
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

        protected int _deleteScheduledReportDaysAfterCompletion;

        [XmlElement(ElementName = "deleteScheduledReportDaysAfterCompletion", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21480")]
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

        protected BroadWorksConnector.Ocip.Models.CallCenterEventRecordingCallCenterEventMode _callCenterEventMode;

        [XmlElement(ElementName = "callCenterEventMode", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21480")]
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
