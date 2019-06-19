using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Hunt Group instance to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting, use value "true" in XS data mode
    /// includeHuntGroupNameInCLID, use value "true" in XS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:25112""}]")]
    public class GroupHuntGroupAddInstanceRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool PolicySpecified { get; set; }

        private bool _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool HuntAfterNoAnswerSpecified { get; set; }

        private int _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool NoAnswerNumberOfRingsSpecified { get; set; }

        private bool _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool ForwardAfterTimeoutSpecified { get; set; }

        private int _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool ForwardTimeoutSecondsSpecified { get; set; }

        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool ForwardToPhoneNumberSpecified { get; set; }

        private List<string> _agentUserId = new List<string>();

        [XmlElement(ElementName = "agentUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
        [MinLength(1)]
        [MaxLength(161)]
        public List<string> AgentUserId
        {
            get => _agentUserId;
            set
            {
                AgentUserIdSpecified = true;
                _agentUserId = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserIdSpecified { get; set; }

        private bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool AllowCallWaitingForAgentsSpecified { get; set; }

        private bool _useSystemHuntGroupCLIDSetting;

        [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool UseSystemHuntGroupCLIDSettingSpecified { get; set; }

        private bool _includeHuntGroupNameInCLID;

        [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool IncludeHuntGroupNameInCLIDSpecified { get; set; }

        private bool _enableNotReachableForwarding;

        [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool EnableNotReachableForwardingSpecified { get; set; }

        private string _notReachableForwardToPhoneNumber;

        [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool NotReachableForwardToPhoneNumberSpecified { get; set; }

        private bool _makeBusyWhenNotReachable;

        [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:25112")]
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
        public bool MakeBusyWhenNotReachableSpecified { get; set; }

    }
}
