using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _taskName;

    [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
    public string TaskName {
        get => _taskName;
        set {
            TaskNameSpecified = true;
            _taskName = value;
        }
    }

    [XmlIgnore]
    public bool TaskNameSpecified { get; set; }
    private string _newTaskName;

    [XmlElement(ElementName = "newTaskName", IsNullable = false, Namespace = "")]
    public string NewTaskName {
        get => _newTaskName;
        set {
            NewTaskNameSpecified = true;
            _newTaskName = value;
        }
    }

    [XmlIgnore]
    public bool NewTaskNameSpecified { get; set; }
    private string _startTimestamp;

    [XmlElement(ElementName = "startTimestamp", IsNullable = false, Namespace = "")]
    public string StartTimestamp {
        get => _startTimestamp;
        set {
            StartTimestampSpecified = true;
            _startTimestamp = value;
        }
    }

    [XmlIgnore]
    public bool StartTimestampSpecified { get; set; }
    private int _expireAfterNumHours;

    [XmlElement(ElementName = "expireAfterNumHours", IsNullable = false, Namespace = "")]
    public int ExpireAfterNumHours {
        get => _expireAfterNumHours;
        set {
            ExpireAfterNumHoursSpecified = true;
            _expireAfterNumHours = value;
        }
    }

    [XmlIgnore]
    public bool ExpireAfterNumHoursSpecified { get; set; }
    private int _maxDurationHours;

    [XmlElement(ElementName = "maxDurationHours", IsNullable = false, Namespace = "")]
    public int MaxDurationHours {
        get => _maxDurationHours;
        set {
            MaxDurationHoursSpecified = true;
            _maxDurationHours = value;
        }
    }

    [XmlIgnore]
    public bool MaxDurationHoursSpecified { get; set; }
    private bool _sendReportEmail;

    [XmlElement(ElementName = "sendReportEmail", IsNullable = false, Namespace = "")]
    public bool SendReportEmail {
        get => _sendReportEmail;
        set {
            SendReportEmailSpecified = true;
            _sendReportEmail = value;
        }
    }

    [XmlIgnore]
    public bool SendReportEmailSpecified { get; set; }
    private string _reportDeliveryEmailAddress;

    [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = true, Namespace = "")]
    public string ReportDeliveryEmailAddress {
        get => _reportDeliveryEmailAddress;
        set {
            ReportDeliveryEmailAddressSpecified = true;
            _reportDeliveryEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool ReportDeliveryEmailAddressSpecified { get; set; }
    private bool _abortOnError;

    [XmlElement(ElementName = "abortOnError", IsNullable = false, Namespace = "")]
    public bool AbortOnError {
        get => _abortOnError;
        set {
            AbortOnErrorSpecified = true;
            _abortOnError = value;
        }
    }

    [XmlIgnore]
    public bool AbortOnErrorSpecified { get; set; }
    private int? _abortErrorThreshold;

    [XmlElement(ElementName = "abortErrorThreshold", IsNullable = true, Namespace = "")]
    public int? AbortErrorThreshold {
        get => _abortErrorThreshold;
        set {
            AbortErrorThresholdSpecified = true;
            _abortErrorThreshold = value;
        }
    }

    [XmlIgnore]
    public bool AbortErrorThresholdSpecified { get; set; }
    private bool _reportAllUsers;

    [XmlElement(ElementName = "reportAllUsers", IsNullable = false, Namespace = "")]
    public bool ReportAllUsers {
        get => _reportAllUsers;
        set {
            ReportAllUsersSpecified = true;
            _reportAllUsers = value;
        }
    }

    [XmlIgnore]
    public bool ReportAllUsersSpecified { get; set; }
    private bool _automaticallyIncrementServiceQuantity;

    [XmlElement(ElementName = "automaticallyIncrementServiceQuantity", IsNullable = false, Namespace = "")]
    public bool AutomaticallyIncrementServiceQuantity {
        get => _automaticallyIncrementServiceQuantity;
        set {
            AutomaticallyIncrementServiceQuantitySpecified = true;
            _automaticallyIncrementServiceQuantity = value;
        }
    }

    [XmlIgnore]
    public bool AutomaticallyIncrementServiceQuantitySpecified { get; set; }
}
}
