using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupHuntGroupGetInstanceRequest19sp1.
    /// Contains the service profile information and a table of assigned users.
    /// The table has column headings: "User Id", "Last Name", "First Name",
    /// "Hiragana Last Name", "Hiragana First Name", "Weight", "Phone Number",
    /// "Extension", "Department", "Email Address".
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting
    /// includeHuntGroupNameInCLID
    /// 
    /// The following elements are only used in XS data mode:
    /// allowMembersToControlGroupBusy
    /// enableGroupBusy
    /// 
    /// Replaced by: GroupHuntGroupGetInstanceResponse20
    /// <see cref="GroupHuntGroupGetInstanceRequest19sp1"/>
    /// <see cref="GroupHuntGroupGetInstanceResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:10858""}]")]
    public class GroupHuntGroupGetInstanceResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy Policy
        {
            get => _policy;
            set
            {
                PolicySpecified = true;
                _policy = value;
            }
        }

        [XmlIgnore]
        protected bool PolicySpecified { get; set; }

        protected bool _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool HuntAfterNoAnswer
        {
            get => _huntAfterNoAnswer;
            set
            {
                HuntAfterNoAnswerSpecified = true;
                _huntAfterNoAnswer = value;
            }
        }

        [XmlIgnore]
        protected bool HuntAfterNoAnswerSpecified { get; set; }

        protected int _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int NoAnswerNumberOfRings
        {
            get => _noAnswerNumberOfRings;
            set
            {
                NoAnswerNumberOfRingsSpecified = true;
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerNumberOfRingsSpecified { get; set; }

        protected bool _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool ForwardAfterTimeout
        {
            get => _forwardAfterTimeout;
            set
            {
                ForwardAfterTimeoutSpecified = true;
                _forwardAfterTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardAfterTimeoutSpecified { get; set; }

        protected int _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        [MinInclusive(0)]
        [MaxInclusive(7200)]
        public int ForwardTimeoutSeconds
        {
            get => _forwardTimeoutSeconds;
            set
            {
                ForwardTimeoutSecondsSpecified = true;
                _forwardTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardTimeoutSecondsSpecified { get; set; }

        protected string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ForwardToPhoneNumber
        {
            get => _forwardToPhoneNumber;
            set
            {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardToPhoneNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _agentUserTable;

        [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AgentUserTable
        {
            get => _agentUserTable;
            set
            {
                AgentUserTableSpecified = true;
                _agentUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserTableSpecified { get; set; }

        protected bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool AllowCallWaitingForAgents
        {
            get => _allowCallWaitingForAgents;
            set
            {
                AllowCallWaitingForAgentsSpecified = true;
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallWaitingForAgentsSpecified { get; set; }

        protected bool _useSystemHuntGroupCLIDSetting;

        [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool UseSystemHuntGroupCLIDSetting
        {
            get => _useSystemHuntGroupCLIDSetting;
            set
            {
                UseSystemHuntGroupCLIDSettingSpecified = true;
                _useSystemHuntGroupCLIDSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemHuntGroupCLIDSettingSpecified { get; set; }

        protected bool _includeHuntGroupNameInCLID;

        [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool IncludeHuntGroupNameInCLID
        {
            get => _includeHuntGroupNameInCLID;
            set
            {
                IncludeHuntGroupNameInCLIDSpecified = true;
                _includeHuntGroupNameInCLID = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeHuntGroupNameInCLIDSpecified { get; set; }

        protected bool _enableNotReachableForwarding;

        [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool EnableNotReachableForwarding
        {
            get => _enableNotReachableForwarding;
            set
            {
                EnableNotReachableForwardingSpecified = true;
                _enableNotReachableForwarding = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNotReachableForwardingSpecified { get; set; }

        protected string _notReachableForwardToPhoneNumber;

        [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        [MinLength(1)]
        [MaxLength(161)]
        public string NotReachableForwardToPhoneNumber
        {
            get => _notReachableForwardToPhoneNumber;
            set
            {
                NotReachableForwardToPhoneNumberSpecified = true;
                _notReachableForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool NotReachableForwardToPhoneNumberSpecified { get; set; }

        protected bool _makeBusyWhenNotReachable;

        [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool MakeBusyWhenNotReachable
        {
            get => _makeBusyWhenNotReachable;
            set
            {
                MakeBusyWhenNotReachableSpecified = true;
                _makeBusyWhenNotReachable = value;
            }
        }

        [XmlIgnore]
        protected bool MakeBusyWhenNotReachableSpecified { get; set; }

        protected bool _allowMembersToControlGroupBusy;

        [XmlElement(ElementName = "allowMembersToControlGroupBusy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool AllowMembersToControlGroupBusy
        {
            get => _allowMembersToControlGroupBusy;
            set
            {
                AllowMembersToControlGroupBusySpecified = true;
                _allowMembersToControlGroupBusy = value;
            }
        }

        [XmlIgnore]
        protected bool AllowMembersToControlGroupBusySpecified { get; set; }

        protected bool _enableGroupBusy;

        [XmlElement(ElementName = "enableGroupBusy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        public bool EnableGroupBusy
        {
            get => _enableGroupBusy;
            set
            {
                EnableGroupBusySpecified = true;
                _enableGroupBusy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableGroupBusySpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:10858")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
