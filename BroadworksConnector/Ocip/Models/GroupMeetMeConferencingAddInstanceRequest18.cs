using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Meet-Me Conferencing bridge to a group.
    /// The domain is required in the serviceUserId.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupMeetMeConferencingAddInstanceRequest18 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId {
            get => _serviceUserId;
            set {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile {
            get => _serviceInstanceProfile;
            set {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

        [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts {
            get => _allocatedPorts;
            set {
                AllocatedPortsSpecified = true;
                _allocatedPorts = value;
            }
        }

        [XmlIgnore]
        public bool AllocatedPortsSpecified { get; set; }
        
        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        public string NetworkClassOfService {
            get => _networkClassOfService;
            set {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }
        
        private bool _allowIndividualOutDial;

        [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false, Namespace = "")]
        public bool AllowIndividualOutDial {
            get => _allowIndividualOutDial;
            set {
                AllowIndividualOutDialSpecified = true;
                _allowIndividualOutDial = value;
            }
        }

        [XmlIgnore]
        public bool AllowIndividualOutDialSpecified { get; set; }
        
        private string _operatorNumber;

        [XmlElement(ElementName = "operatorNumber", IsNullable = false, Namespace = "")]
        public string OperatorNumber {
            get => _operatorNumber;
            set {
                OperatorNumberSpecified = true;
                _operatorNumber = value;
            }
        }

        [XmlIgnore]
        public bool OperatorNumberSpecified { get; set; }
        
        private List<string> _conferenceHostUserId;

        [XmlElement(ElementName = "conferenceHostUserId", IsNullable = false, Namespace = "")]
        public List<string> ConferenceHostUserId {
            get => _conferenceHostUserId;
            set {
                ConferenceHostUserIdSpecified = true;
                _conferenceHostUserId = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceHostUserIdSpecified { get; set; }
        
        private bool _playWarningPrompt;

        [XmlElement(ElementName = "playWarningPrompt", IsNullable = false, Namespace = "")]
        public bool PlayWarningPrompt {
            get => _playWarningPrompt;
            set {
                PlayWarningPromptSpecified = true;
                _playWarningPrompt = value;
            }
        }

        [XmlIgnore]
        public bool PlayWarningPromptSpecified { get; set; }
        
        private int _conferenceEndWarningPromptMinutes;

        [XmlElement(ElementName = "conferenceEndWarningPromptMinutes", IsNullable = false, Namespace = "")]
        public int ConferenceEndWarningPromptMinutes {
            get => _conferenceEndWarningPromptMinutes;
            set {
                ConferenceEndWarningPromptMinutesSpecified = true;
                _conferenceEndWarningPromptMinutes = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceEndWarningPromptMinutesSpecified { get; set; }
        
        private bool _enableMaxConferenceDuration;

        [XmlElement(ElementName = "enableMaxConferenceDuration", IsNullable = false, Namespace = "")]
        public bool EnableMaxConferenceDuration {
            get => _enableMaxConferenceDuration;
            set {
                EnableMaxConferenceDurationSpecified = true;
                _enableMaxConferenceDuration = value;
            }
        }

        [XmlIgnore]
        public bool EnableMaxConferenceDurationSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _maxConferenceDurationMinutes;

        [XmlElement(ElementName = "maxConferenceDurationMinutes", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration MaxConferenceDurationMinutes {
            get => _maxConferenceDurationMinutes;
            set {
                MaxConferenceDurationMinutesSpecified = true;
                _maxConferenceDurationMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxConferenceDurationMinutesSpecified { get; set; }
        
    }
}
