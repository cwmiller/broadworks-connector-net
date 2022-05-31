using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a GroupTrunkGroupUserCreationTaskGetRequest.
    /// <see cref="GroupTrunkGroupUserCreationTaskGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16084""}]")]
    public class GroupTrunkGroupUserCreationTaskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat _userIdFormat;

        [XmlElement(ElementName = "userIdFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat UserIdFormat
        {
            get => _userIdFormat;
            set
            {
                UserIdFormatSpecified = true;
                _userIdFormat = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdFormatSpecified { get; set; }

        protected string _userIdDomain;

        [XmlElement(ElementName = "userIdDomain", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        [MinLength(1)]
        [MaxLength(80)]
        public string UserIdDomain
        {
            get => _userIdDomain;
            set
            {
                UserIdDomainSpecified = true;
                _userIdDomain = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdDomainSpecified { get; set; }

        protected bool _populateExtension;

        [XmlElement(ElementName = "populateExtension", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public bool PopulateExtension
        {
            get => _populateExtension;
            set
            {
                PopulateExtensionSpecified = true;
                _populateExtension = value;
            }
        }

        [XmlIgnore]
        protected bool PopulateExtensionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _linePortFormat;

        [XmlElement(ElementName = "linePortFormat", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat LinePortFormat
        {
            get => _linePortFormat;
            set
            {
                LinePortFormatSpecified = true;
                _linePortFormat = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortFormatSpecified { get; set; }

        protected string _linePortDomain;

        [XmlElement(ElementName = "linePortDomain", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        [MinLength(1)]
        [MaxLength(80)]
        public string LinePortDomain
        {
            get => _linePortDomain;
            set
            {
                LinePortDomainSpecified = true;
                _linePortDomain = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortDomainSpecified { get; set; }

        protected bool _populateContact;

        [XmlElement(ElementName = "populateContact", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public bool PopulateContact
        {
            get => _populateContact;
            set
            {
                PopulateContactSpecified = true;
                _populateContact = value;
            }
        }

        [XmlIgnore]
        protected bool PopulateContactSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat _contactFormat;

        [XmlElement(ElementName = "contactFormat", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat ContactFormat
        {
            get => _contactFormat;
            set
            {
                ContactFormatSpecified = true;
                _contactFormat = value;
            }
        }

        [XmlIgnore]
        protected bool ContactFormatSpecified { get; set; }

        protected string _contactDomain;

        [XmlElement(ElementName = "contactDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ContactDomain
        {
            get => _contactDomain;
            set
            {
                ContactDomainSpecified = true;
                _contactDomain = value;
            }
        }

        [XmlIgnore]
        protected bool ContactDomainSpecified { get; set; }

        protected int _usersCreated;

        [XmlElement(ElementName = "usersCreated", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public int UsersCreated
        {
            get => _usersCreated;
            set
            {
                UsersCreatedSpecified = true;
                _usersCreated = value;
            }
        }

        [XmlIgnore]
        protected bool UsersCreatedSpecified { get; set; }

        protected int _totalUsersToCreate;

        [XmlElement(ElementName = "totalUsersToCreate", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public int TotalUsersToCreate
        {
            get => _totalUsersToCreate;
            set
            {
                TotalUsersToCreateSpecified = true;
                _totalUsersToCreate = value;
            }
        }

        [XmlIgnore]
        protected bool TotalUsersToCreateSpecified { get; set; }

        protected int _errorCount;

        [XmlElement(ElementName = "errorCount", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
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

        protected List<string> _servicePackName = new List<string>();

        [XmlElement(ElementName = "servicePackName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> ServicePackName
        {
            get => _servicePackName;
            set
            {
                ServicePackNameSpecified = true;
                _servicePackName = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackNameSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.UserService> _userServiceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "userServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public List<BroadWorksConnector.Ocip.Models.UserService> UserServiceName
        {
            get => _userServiceName;
            set
            {
                UserServiceNameSpecified = true;
                _userServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationTaskStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationTaskStatus Status
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

        protected BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationMode _userCreationMode;

        [XmlElement(ElementName = "userCreationMode", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupUserCreationMode UserCreationMode
        {
            get => _userCreationMode;
            set
            {
                UserCreationModeSpecified = true;
                _userCreationMode = value;
            }
        }

        [XmlIgnore]
        protected bool UserCreationModeSpecified { get; set; }

        protected string _taskSummary;

        [XmlElement(ElementName = "taskSummary", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16084")]
        public string TaskSummary
        {
            get => _taskSummary;
            set
            {
                TaskSummarySpecified = true;
                _taskSummary = value;
            }
        }

        [XmlIgnore]
        protected bool TaskSummarySpecified { get; set; }

    }
}
