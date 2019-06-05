using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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

    [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = false, Namespace = "")]
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
    private int _abortErrorThreshold;

    [XmlElement(ElementName = "abortErrorThreshold", IsNullable = false, Namespace = "")]
    public int AbortErrorThreshold {
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
    private int _errorCount;

    [XmlElement(ElementName = "errorCount", IsNullable = false, Namespace = "")]
    public int ErrorCount {
        get => _errorCount;
        set {
            ErrorCountSpecified = true;
            _errorCount = value;
        }
    }

    [XmlIgnore]
    public bool ErrorCountSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServicePackMigrationTaskStatus _status;

    [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServicePackMigrationTaskStatus Status {
        get => _status;
        set {
            StatusSpecified = true;
            _status = value;
        }
    }

    [XmlIgnore]
    public bool StatusSpecified { get; set; }
    private int _groupsProcessed;

    [XmlElement(ElementName = "groupsProcessed", IsNullable = false, Namespace = "")]
    public int GroupsProcessed {
        get => _groupsProcessed;
        set {
            GroupsProcessedSpecified = true;
            _groupsProcessed = value;
        }
    }

    [XmlIgnore]
    public bool GroupsProcessedSpecified { get; set; }
    private int _groupsTotal;

    [XmlElement(ElementName = "groupsTotal", IsNullable = false, Namespace = "")]
    public int GroupsTotal {
        get => _groupsTotal;
        set {
            GroupsTotalSpecified = true;
            _groupsTotal = value;
        }
    }

    [XmlIgnore]
    public bool GroupsTotalSpecified { get; set; }
    private int _usersProcessed;

    [XmlElement(ElementName = "usersProcessed", IsNullable = false, Namespace = "")]
    public int UsersProcessed {
        get => _usersProcessed;
        set {
            UsersProcessedSpecified = true;
            _usersProcessed = value;
        }
    }

    [XmlIgnore]
    public bool UsersProcessedSpecified { get; set; }
    private int _usersTotal;

    [XmlElement(ElementName = "usersTotal", IsNullable = false, Namespace = "")]
    public int UsersTotal {
        get => _usersTotal;
        set {
            UsersTotalSpecified = true;
            _usersTotal = value;
        }
    }

    [XmlIgnore]
    public bool UsersTotalSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType _userSelectionType;

    [XmlElement(ElementName = "userSelectionType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType UserSelectionType {
        get => _userSelectionType;
        set {
            UserSelectionTypeSpecified = true;
            _userSelectionType = value;
        }
    }

    [XmlIgnore]
    public bool UserSelectionTypeSpecified { get; set; }
    private string _reportFilePathName;

    [XmlElement(ElementName = "reportFilePathName", IsNullable = false, Namespace = "")]
    public string ReportFilePathName {
        get => _reportFilePathName;
        set {
            ReportFilePathNameSpecified = true;
            _reportFilePathName = value;
        }
    }

    [XmlIgnore]
    public bool ReportFilePathNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _groupTable;

    [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupTable {
        get => _groupTable;
        set {
            GroupTableSpecified = true;
            _groupTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupTableSpecified { get; set; }
    private List<string> _userSelectionServicePackName;

    [XmlElement(ElementName = "userSelectionServicePackName", IsNullable = false, Namespace = "")]
    public List<string> UserSelectionServicePackName {
        get => _userSelectionServicePackName;
        set {
            UserSelectionServicePackNameSpecified = true;
            _userSelectionServicePackName = value;
        }
    }

    [XmlIgnore]
    public bool UserSelectionServicePackNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.UserService> _userSelectionServiceName;

    [XmlElement(ElementName = "userSelectionServiceName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.UserService> UserSelectionServiceName {
        get => _userSelectionServiceName;
        set {
            UserSelectionServiceNameSpecified = true;
            _userSelectionServiceName = value;
        }
    }

    [XmlIgnore]
    public bool UserSelectionServiceNameSpecified { get; set; }
    private List<string> _removeServicePackName;

    [XmlElement(ElementName = "removeServicePackName", IsNullable = false, Namespace = "")]
    public List<string> RemoveServicePackName {
        get => _removeServicePackName;
        set {
            RemoveServicePackNameSpecified = true;
            _removeServicePackName = value;
        }
    }

    [XmlIgnore]
    public bool RemoveServicePackNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.UserService> _removeServiceName;

    [XmlElement(ElementName = "removeServiceName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.UserService> RemoveServiceName {
        get => _removeServiceName;
        set {
            RemoveServiceNameSpecified = true;
            _removeServiceName = value;
        }
    }

    [XmlIgnore]
    public bool RemoveServiceNameSpecified { get; set; }
    private List<string> _assignServicePackName;

    [XmlElement(ElementName = "assignServicePackName", IsNullable = false, Namespace = "")]
    public List<string> AssignServicePackName {
        get => _assignServicePackName;
        set {
            AssignServicePackNameSpecified = true;
            _assignServicePackName = value;
        }
    }

    [XmlIgnore]
    public bool AssignServicePackNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.UserService> _assignServiceName;

    [XmlElement(ElementName = "assignServiceName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.UserService> AssignServiceName {
        get => _assignServiceName;
        set {
            AssignServiceNameSpecified = true;
            _assignServiceName = value;
        }
    }

    [XmlIgnore]
    public bool AssignServiceNameSpecified { get; set; }
}
}
