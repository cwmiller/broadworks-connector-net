using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServicePackMigrationTaskGetRequest14sp4.
    /// The groupTable column headings are: "Group Id", "Group Name", "User Count".
    /// 
    /// Replaced By: ServiceProviderServicePackMigrationTaskGetResponse21 in AS data mode
    /// <see cref="ServiceProviderServicePackMigrationTaskGetRequest14sp4"/>
    /// <see cref="ServiceProviderServicePackMigrationTaskGetResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:7320"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:7338""}]}]")]
    public class ServiceProviderServicePackMigrationTaskGetResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _taskName;

        [XmlElement(ElementName = "taskName", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool TaskNameSpecified { get; set; }

        protected string _startTimestamp;

        [XmlElement(ElementName = "startTimestamp", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool StartTimestampSpecified { get; set; }

        protected int _maxDurationHours;

        [XmlElement(ElementName = "maxDurationHours", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool MaxDurationHoursSpecified { get; set; }

        protected bool _sendReportEmail;

        [XmlElement(ElementName = "sendReportEmail", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool SendReportEmailSpecified { get; set; }

        protected string _reportDeliveryEmailAddress;

        [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool ReportDeliveryEmailAddressSpecified { get; set; }

        protected bool _abortOnError;

        [XmlElement(ElementName = "abortOnError", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool AbortOnErrorSpecified { get; set; }

        protected int _abortErrorThreshold;

        [XmlElement(ElementName = "abortErrorThreshold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool AbortErrorThresholdSpecified { get; set; }

        protected bool _reportAllUsers;

        [XmlElement(ElementName = "reportAllUsers", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool ReportAllUsersSpecified { get; set; }

        protected bool _automaticallyIncrementServiceQuantity;

        [XmlElement(ElementName = "automaticallyIncrementServiceQuantity", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
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
        protected bool AutomaticallyIncrementServiceQuantitySpecified { get; set; }

        protected int _errorCount;

        [XmlElement(ElementName = "errorCount", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public int ErrorCount
        {
            get => _errorCount;
            set
            {
                ErrorCountSpecified = true;
                _errorCount = value;
            }
        }

        [XmlIgnore]
        protected bool ErrorCountSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskStatus Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        protected bool StatusSpecified { get; set; }

        protected int _groupsProcessed;

        [XmlElement(ElementName = "groupsProcessed", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public int GroupsProcessed
        {
            get => _groupsProcessed;
            set
            {
                GroupsProcessedSpecified = true;
                _groupsProcessed = value;
            }
        }

        [XmlIgnore]
        protected bool GroupsProcessedSpecified { get; set; }

        protected int _groupsTotal;

        [XmlElement(ElementName = "groupsTotal", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public int GroupsTotal
        {
            get => _groupsTotal;
            set
            {
                GroupsTotalSpecified = true;
                _groupsTotal = value;
            }
        }

        [XmlIgnore]
        protected bool GroupsTotalSpecified { get; set; }

        protected int _usersProcessed;

        [XmlElement(ElementName = "usersProcessed", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public int UsersProcessed
        {
            get => _usersProcessed;
            set
            {
                UsersProcessedSpecified = true;
                _usersProcessed = value;
            }
        }

        [XmlIgnore]
        protected bool UsersProcessedSpecified { get; set; }

        protected int _usersTotal;

        [XmlElement(ElementName = "usersTotal", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public int UsersTotal
        {
            get => _usersTotal;
            set
            {
                UsersTotalSpecified = true;
                _usersTotal = value;
            }
        }

        [XmlIgnore]
        protected bool UsersTotalSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType _userSelectionType;

        [XmlElement(ElementName = "userSelectionType", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public BroadWorksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType UserSelectionType
        {
            get => _userSelectionType;
            set
            {
                UserSelectionTypeSpecified = true;
                _userSelectionType = value;
            }
        }

        [XmlIgnore]
        protected bool UserSelectionTypeSpecified { get; set; }

        protected string _reportFilePathName;

        [XmlElement(ElementName = "reportFilePathName", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        [MinLength(1)]
        public string ReportFilePathName
        {
            get => _reportFilePathName;
            set
            {
                ReportFilePathNameSpecified = true;
                _reportFilePathName = value;
            }
        }

        [XmlIgnore]
        protected bool ReportFilePathNameSpecified { get; set; }

        protected bool _migrateAllGroups;

        [XmlElement(ElementName = "migrateAllGroups", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7338")]
        public bool MigrateAllGroups
        {
            get => _migrateAllGroups;
            set
            {
                MigrateAllGroupsSpecified = true;
                _migrateAllGroups = value;
            }
        }

        [XmlIgnore]
        protected bool MigrateAllGroupsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7338")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupTable
        {
            get => _groupTable;
            set
            {
                GroupTableSpecified = true;
                _groupTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupTableSpecified { get; set; }

        protected List<string> _userSelectionServicePackName = new List<string>();

        [XmlElement(ElementName = "userSelectionServicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> UserSelectionServicePackName
        {
            get => _userSelectionServicePackName;
            set
            {
                UserSelectionServicePackNameSpecified = true;
                _userSelectionServicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool UserSelectionServicePackNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserService> _userSelectionServiceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "userSelectionServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public List<BroadWorksConnector.Ocip.Models.UserService> UserSelectionServiceName
        {
            get => _userSelectionServiceName;
            set
            {
                UserSelectionServiceNameSpecified = true;
                _userSelectionServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool UserSelectionServiceNameSpecified { get; set; }

        protected List<string> _removeServicePackName = new List<string>();

        [XmlElement(ElementName = "removeServicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> RemoveServicePackName
        {
            get => _removeServicePackName;
            set
            {
                RemoveServicePackNameSpecified = true;
                _removeServicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool RemoveServicePackNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserService> _removeServiceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "removeServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public List<BroadWorksConnector.Ocip.Models.UserService> RemoveServiceName
        {
            get => _removeServiceName;
            set
            {
                RemoveServiceNameSpecified = true;
                _removeServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool RemoveServiceNameSpecified { get; set; }

        protected List<string> _assignServicePackName = new List<string>();

        [XmlElement(ElementName = "assignServicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> AssignServicePackName
        {
            get => _assignServicePackName;
            set
            {
                AssignServicePackNameSpecified = true;
                _assignServicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool AssignServicePackNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserService> _assignServiceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "assignServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7320")]
        public List<BroadWorksConnector.Ocip.Models.UserService> AssignServiceName
        {
            get => _assignServiceName;
            set
            {
                AssignServiceNameSpecified = true;
                _assignServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool AssignServiceNameSpecified { get; set; }

    }
}
