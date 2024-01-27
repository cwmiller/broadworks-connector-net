using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest25.
    /// <see cref="SystemCallCenterEnhancedReportingScheduledTaskParametersGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6427""}]")]
    public class SystemCallCenterEnhancedReportingScheduledTaskParametersGetResponse25 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _scheduledReportSearchIntervalMinutes;

        [XmlElement(ElementName = "scheduledReportSearchIntervalMinutes", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6427")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:6427")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:6427")]
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
        [Group(@"4d65d3449061c568639c8cc1e2492285:6427")]
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

        protected bool _useDialedAddressForRemoteNumber;

        [XmlElement(ElementName = "useDialedAddressForRemoteNumber", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6427")]
        public bool UseDialedAddressForRemoteNumber
        {
            get => _useDialedAddressForRemoteNumber;
            set
            {
                UseDialedAddressForRemoteNumberSpecified = true;
                _useDialedAddressForRemoteNumber = value;
            }
        }

        [XmlIgnore]
        protected bool UseDialedAddressForRemoteNumberSpecified { get; set; }

    }
}
