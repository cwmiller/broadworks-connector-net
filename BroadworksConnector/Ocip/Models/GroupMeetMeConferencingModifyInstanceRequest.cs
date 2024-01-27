using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Meet-Me Conferencing bridge.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:288""}]")]
    public class GroupMeetMeConferencingModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
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

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

        [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected int _securityPinLength;

        [XmlElement(ElementName = "securityPinLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected bool _allowIndividualOutDial;

        [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected string _operatorNumber;

        [XmlElement(ElementName = "operatorNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _conferenceHostUserIdList;

        [XmlElement(ElementName = "conferenceHostUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList ConferenceHostUserIdList
        {
            get => _conferenceHostUserIdList;
            set
            {
                ConferenceHostUserIdListSpecified = true;
                _conferenceHostUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceHostUserIdListSpecified { get; set; }

        protected bool _playWarningPrompt;

        [XmlElement(ElementName = "playWarningPrompt", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected int _conferenceEndWarningPromptMinutes;

        [XmlElement(ElementName = "conferenceEndWarningPromptMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected bool _enableMaxConferenceDuration;

        [XmlElement(ElementName = "enableMaxConferenceDuration", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _maxConferenceDurationMinutes;

        [XmlElement(ElementName = "maxConferenceDurationMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _maxScheduledConferenceDurationMinutes;

        [XmlElement(ElementName = "maxScheduledConferenceDurationMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:288")]
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
