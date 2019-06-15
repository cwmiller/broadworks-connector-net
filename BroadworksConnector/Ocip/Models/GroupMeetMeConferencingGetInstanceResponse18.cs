using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupMeetMeConferencingGetInstanceRequest18.
    /// Contains the service profile information and a table of assigned hosts.
    /// The table has column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", Phone Number", "Extension", "Department", "Email Address".
        /// <see cref="GroupMeetMeConferencingGetInstanceRequest18"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupMeetMeConferencingGetInstanceResponse18 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17sp4 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile17sp4 ServiceInstanceProfile {
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
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceHostUserTable;

        [XmlElement(ElementName = "conferenceHostUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceHostUserTable {
            get => _conferenceHostUserTable;
            set {
                ConferenceHostUserTableSpecified = true;
                _conferenceHostUserTable = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceHostUserTableSpecified { get; set; }
        
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
