using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Create a service pack migration task.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5416""}]")]
    public class ServiceProviderServicePackMigrationTaskAddRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TaskName
        {
            get => _taskName;
            set
            {
                TaskNameSpecified = true;
                _taskName = value;
            }
        }

        [XmlIgnore]
        public bool TaskNameSpecified { get; set; }

        private string _startTimestamp;

        [XmlElement(ElementName = "startTimestamp", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        public string StartTimestamp
        {
            get => _startTimestamp;
            set
            {
                StartTimestampSpecified = true;
                _startTimestamp = value;
            }
        }

        [XmlIgnore]
        public bool StartTimestampSpecified { get; set; }

        private int _expireAfterNumHours;

        [XmlElement(ElementName = "expireAfterNumHours", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        [MinInclusive(1)]
        [MaxInclusive(168)]
        public int ExpireAfterNumHours
        {
            get => _expireAfterNumHours;
            set
            {
                ExpireAfterNumHoursSpecified = true;
                _expireAfterNumHours = value;
            }
        }

        [XmlIgnore]
        public bool ExpireAfterNumHoursSpecified { get; set; }

        private int _maxDurationHours;

        [XmlElement(ElementName = "maxDurationHours", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        [MinInclusive(1)]
        [MaxInclusive(9)]
        public int MaxDurationHours
        {
            get => _maxDurationHours;
            set
            {
                MaxDurationHoursSpecified = true;
                _maxDurationHours = value;
            }
        }

        [XmlIgnore]
        public bool MaxDurationHoursSpecified { get; set; }

        private bool _sendReportEmail;

        [XmlElement(ElementName = "sendReportEmail", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        public bool SendReportEmail
        {
            get => _sendReportEmail;
            set
            {
                SendReportEmailSpecified = true;
                _sendReportEmail = value;
            }
        }

        [XmlIgnore]
        public bool SendReportEmailSpecified { get; set; }

        private string _reportDeliveryEmailAddress;

        [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ReportDeliveryEmailAddress
        {
            get => _reportDeliveryEmailAddress;
            set
            {
                ReportDeliveryEmailAddressSpecified = true;
                _reportDeliveryEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool ReportDeliveryEmailAddressSpecified { get; set; }

        private bool _abortOnError;

        [XmlElement(ElementName = "abortOnError", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        public bool AbortOnError
        {
            get => _abortOnError;
            set
            {
                AbortOnErrorSpecified = true;
                _abortOnError = value;
            }
        }

        [XmlIgnore]
        public bool AbortOnErrorSpecified { get; set; }

        private int _abortErrorThreshold;

        [XmlElement(ElementName = "abortErrorThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        [MinInclusive(1)]
        public int AbortErrorThreshold
        {
            get => _abortErrorThreshold;
            set
            {
                AbortErrorThresholdSpecified = true;
                _abortErrorThreshold = value;
            }
        }

        [XmlIgnore]
        public bool AbortErrorThresholdSpecified { get; set; }

        private bool _reportAllUsers;

        [XmlElement(ElementName = "reportAllUsers", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        public bool ReportAllUsers
        {
            get => _reportAllUsers;
            set
            {
                ReportAllUsersSpecified = true;
                _reportAllUsers = value;
            }
        }

        [XmlIgnore]
        public bool ReportAllUsersSpecified { get; set; }

        private bool _automaticallyIncrementServiceQuantity;

        [XmlElement(ElementName = "automaticallyIncrementServiceQuantity", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5416")]
        public bool AutomaticallyIncrementServiceQuantity
        {
            get => _automaticallyIncrementServiceQuantity;
            set
            {
                AutomaticallyIncrementServiceQuantitySpecified = true;
                _automaticallyIncrementServiceQuantity = value;
            }
        }

        [XmlIgnore]
        public bool AutomaticallyIncrementServiceQuantitySpecified { get; set; }

    }
}
