using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupHuntGroupGetInstanceRequest17sp4.
    /// Contains the service profile information and a table of assigned users.
    /// The table has column headings: "User Id", "Last Name", "First Name",
    /// "Hiragana Last Name", "Hiragana First Name", "Weight", "Phone Number",
    /// "Extension", "Department", "Email Address".
    /// The following elements are only used in AS data mode:
    /// useSystemHuntGroupCLIDSetting
    /// includeHuntGroupNameInCLID
        /// <see cref="GroupHuntGroupGetInstanceRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupHuntGroupGetInstanceResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy Policy {
            get => _policy;
            set {
                PolicySpecified = true;
                _policy = value;
            }
        }

        [XmlIgnore]
        public bool PolicySpecified { get; set; }
        
        private bool _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        public bool HuntAfterNoAnswer {
            get => _huntAfterNoAnswer;
            set {
                HuntAfterNoAnswerSpecified = true;
                _huntAfterNoAnswer = value;
            }
        }

        [XmlIgnore]
        public bool HuntAfterNoAnswerSpecified { get; set; }
        
        private int _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        public int NoAnswerNumberOfRings {
            get => _noAnswerNumberOfRings;
            set {
                NoAnswerNumberOfRingsSpecified = true;
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        public bool NoAnswerNumberOfRingsSpecified { get; set; }
        
        private bool _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        public bool ForwardAfterTimeout {
            get => _forwardAfterTimeout;
            set {
                ForwardAfterTimeoutSpecified = true;
                _forwardAfterTimeout = value;
            }
        }

        [XmlIgnore]
        public bool ForwardAfterTimeoutSpecified { get; set; }
        
        private int _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int ForwardTimeoutSeconds {
            get => _forwardTimeoutSeconds;
            set {
                ForwardTimeoutSecondsSpecified = true;
                _forwardTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ForwardTimeoutSecondsSpecified { get; set; }
        
        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        public string ForwardToPhoneNumber {
            get => _forwardToPhoneNumber;
            set {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool ForwardToPhoneNumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _agentUserTable;

        [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AgentUserTable {
            get => _agentUserTable;
            set {
                AgentUserTableSpecified = true;
                _agentUserTable = value;
            }
        }

        [XmlIgnore]
        public bool AgentUserTableSpecified { get; set; }
        
        private bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        public bool AllowCallWaitingForAgents {
            get => _allowCallWaitingForAgents;
            set {
                AllowCallWaitingForAgentsSpecified = true;
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        public bool AllowCallWaitingForAgentsSpecified { get; set; }
        
        private bool _useSystemHuntGroupCLIDSetting;

        [XmlElement(ElementName = "useSystemHuntGroupCLIDSetting", IsNullable = false, Namespace = "")]
        public bool UseSystemHuntGroupCLIDSetting {
            get => _useSystemHuntGroupCLIDSetting;
            set {
                UseSystemHuntGroupCLIDSettingSpecified = true;
                _useSystemHuntGroupCLIDSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseSystemHuntGroupCLIDSettingSpecified { get; set; }
        
        private bool _includeHuntGroupNameInCLID;

        [XmlElement(ElementName = "includeHuntGroupNameInCLID", IsNullable = false, Namespace = "")]
        public bool IncludeHuntGroupNameInCLID {
            get => _includeHuntGroupNameInCLID;
            set {
                IncludeHuntGroupNameInCLIDSpecified = true;
                _includeHuntGroupNameInCLID = value;
            }
        }

        [XmlIgnore]
        public bool IncludeHuntGroupNameInCLIDSpecified { get; set; }
        
        private bool _enableNotReachableForwarding;

        [XmlElement(ElementName = "enableNotReachableForwarding", IsNullable = false, Namespace = "")]
        public bool EnableNotReachableForwarding {
            get => _enableNotReachableForwarding;
            set {
                EnableNotReachableForwardingSpecified = true;
                _enableNotReachableForwarding = value;
            }
        }

        [XmlIgnore]
        public bool EnableNotReachableForwardingSpecified { get; set; }
        
        private string _notReachableForwardToPhoneNumber;

        [XmlElement(ElementName = "notReachableForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        public string NotReachableForwardToPhoneNumber {
            get => _notReachableForwardToPhoneNumber;
            set {
                NotReachableForwardToPhoneNumberSpecified = true;
                _notReachableForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool NotReachableForwardToPhoneNumberSpecified { get; set; }
        
        private bool _makeBusyWhenNotReachable;

        [XmlElement(ElementName = "makeBusyWhenNotReachable", IsNullable = false, Namespace = "")]
        public bool MakeBusyWhenNotReachable {
            get => _makeBusyWhenNotReachable;
            set {
                MakeBusyWhenNotReachableSpecified = true;
                _makeBusyWhenNotReachable = value;
            }
        }

        [XmlIgnore]
        public bool MakeBusyWhenNotReachableSpecified { get; set; }
        
    }
}
