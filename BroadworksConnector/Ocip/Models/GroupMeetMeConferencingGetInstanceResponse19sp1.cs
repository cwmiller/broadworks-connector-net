using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupMeetMeConferencingGetInstanceRequest19sp1.
    /// Contains the service profile information and a table of assigned hosts.
    /// The table has column headings: "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="GroupMeetMeConferencingGetInstanceRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:213""}]")]
    public class GroupMeetMeConferencingGetInstanceResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
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

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

        [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts
        {
            get => _allocatedPorts;
            set
            {
                AllocatedPortsSpecified = true;
                _allocatedPorts = value;
            }
        }

        [XmlIgnore]
        protected bool AllocatedPortsSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
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

        private int _securityPinLength;

        [XmlElement(ElementName = "securityPinLength", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        [MinInclusive(4)]
        [MaxInclusive(12)]
        public int SecurityPinLength
        {
            get => _securityPinLength;
            set
            {
                SecurityPinLengthSpecified = true;
                _securityPinLength = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityPinLengthSpecified { get; set; }

        private bool _allowIndividualOutDial;

        [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        public bool AllowIndividualOutDial
        {
            get => _allowIndividualOutDial;
            set
            {
                AllowIndividualOutDialSpecified = true;
                _allowIndividualOutDial = value;
            }
        }

        [XmlIgnore]
        protected bool AllowIndividualOutDialSpecified { get; set; }

        private string _operatorNumber;

        [XmlElement(ElementName = "operatorNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        [MinLength(1)]
        [MaxLength(161)]
        public string OperatorNumber
        {
            get => _operatorNumber;
            set
            {
                OperatorNumberSpecified = true;
                _operatorNumber = value;
            }
        }

        [XmlIgnore]
        protected bool OperatorNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceHostUserTable;

        [XmlElement(ElementName = "conferenceHostUserTable", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceHostUserTable
        {
            get => _conferenceHostUserTable;
            set
            {
                ConferenceHostUserTableSpecified = true;
                _conferenceHostUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceHostUserTableSpecified { get; set; }

        private bool _playWarningPrompt;

        [XmlElement(ElementName = "playWarningPrompt", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        public bool PlayWarningPrompt
        {
            get => _playWarningPrompt;
            set
            {
                PlayWarningPromptSpecified = true;
                _playWarningPrompt = value;
            }
        }

        [XmlIgnore]
        protected bool PlayWarningPromptSpecified { get; set; }

        private int _conferenceEndWarningPromptMinutes;

        [XmlElement(ElementName = "conferenceEndWarningPromptMinutes", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
        public int ConferenceEndWarningPromptMinutes
        {
            get => _conferenceEndWarningPromptMinutes;
            set
            {
                ConferenceEndWarningPromptMinutesSpecified = true;
                _conferenceEndWarningPromptMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceEndWarningPromptMinutesSpecified { get; set; }

        private bool _enableMaxConferenceDuration;

        [XmlElement(ElementName = "enableMaxConferenceDuration", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        public bool EnableMaxConferenceDuration
        {
            get => _enableMaxConferenceDuration;
            set
            {
                EnableMaxConferenceDurationSpecified = true;
                _enableMaxConferenceDuration = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMaxConferenceDurationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _maxConferenceDurationMinutes;

        [XmlElement(ElementName = "maxConferenceDurationMinutes", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration MaxConferenceDurationMinutes
        {
            get => _maxConferenceDurationMinutes;
            set
            {
                MaxConferenceDurationMinutesSpecified = true;
                _maxConferenceDurationMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConferenceDurationMinutesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _maxScheduledConferenceDurationMinutes;

        [XmlElement(ElementName = "maxScheduledConferenceDurationMinutes", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:213")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration MaxScheduledConferenceDurationMinutes
        {
            get => _maxScheduledConferenceDurationMinutes;
            set
            {
                MaxScheduledConferenceDurationMinutesSpecified = true;
                _maxScheduledConferenceDurationMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxScheduledConferenceDurationMinutesSpecified { get; set; }

    }
}
