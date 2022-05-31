using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCollaborateGetRequest.
    /// 
    /// Replaced by: SystemCollaborateGetResponse20sp1
    /// <see cref="SystemCollaborateGetRequest"/>
    /// <see cref="SystemCollaborateGetResponse20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24834""}]")]
    public class SystemCollaborateGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _collaborateRoomIdLength;

        [XmlElement(ElementName = "collaborateRoomIdLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        [MinInclusive(4)]
        [MaxInclusive(15)]
        public int CollaborateRoomIdLength
        {
            get => _collaborateRoomIdLength;
            set
            {
                CollaborateRoomIdLengthSpecified = true;
                _collaborateRoomIdLength = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateRoomIdLengthSpecified { get; set; }

        protected int _instantRoomIdleTimeoutSeconds;

        [XmlElement(ElementName = "instantRoomIdleTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        [MinInclusive(1)]
        [MaxInclusive(3600)]
        public int InstantRoomIdleTimeoutSeconds
        {
            get => _instantRoomIdleTimeoutSeconds;
            set
            {
                InstantRoomIdleTimeoutSecondsSpecified = true;
                _instantRoomIdleTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool InstantRoomIdleTimeoutSecondsSpecified { get; set; }

        protected int _collaborateRoomMaximumDurationMinutes;

        [XmlElement(ElementName = "collaborateRoomMaximumDurationMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public int CollaborateRoomMaximumDurationMinutes
        {
            get => _collaborateRoomMaximumDurationMinutes;
            set
            {
                CollaborateRoomMaximumDurationMinutesSpecified = true;
                _collaborateRoomMaximumDurationMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateRoomMaximumDurationMinutesSpecified { get; set; }

        protected bool _supportOutdial;

        [XmlElement(ElementName = "supportOutdial", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        public bool SupportOutdial
        {
            get => _supportOutdial;
            set
            {
                SupportOutdialSpecified = true;
                _supportOutdial = value;
            }
        }

        [XmlIgnore]
        protected bool SupportOutdialSpecified { get; set; }

        protected int _maxCollaborateRoomParticipants;

        [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        [MinInclusive(3)]
        [MaxInclusive(30)]
        public int MaxCollaborateRoomParticipants
        {
            get => _maxCollaborateRoomParticipants;
            set
            {
                MaxCollaborateRoomParticipantsSpecified = true;
                _maxCollaborateRoomParticipants = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCollaborateRoomParticipantsSpecified { get; set; }

        protected int _collaborateActiveTalkerRefreshIntervalSeconds;

        [XmlElement(ElementName = "collaborateActiveTalkerRefreshIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int CollaborateActiveTalkerRefreshIntervalSeconds
        {
            get => _collaborateActiveTalkerRefreshIntervalSeconds;
            set
            {
                CollaborateActiveTalkerRefreshIntervalSecondsSpecified = true;
                _collaborateActiveTalkerRefreshIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateActiveTalkerRefreshIntervalSecondsSpecified { get; set; }

        protected bool _terminateCollaborateAfterGracePeriod;

        [XmlElement(ElementName = "terminateCollaborateAfterGracePeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        public bool TerminateCollaborateAfterGracePeriod
        {
            get => _terminateCollaborateAfterGracePeriod;
            set
            {
                TerminateCollaborateAfterGracePeriodSpecified = true;
                _terminateCollaborateAfterGracePeriod = value;
            }
        }

        [XmlIgnore]
        protected bool TerminateCollaborateAfterGracePeriodSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CollaborateGracePeriodDuration _collaborateGracePeriod;

        [XmlElement(ElementName = "collaborateGracePeriod", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        public BroadWorksConnector.Ocip.Models.CollaborateGracePeriodDuration CollaborateGracePeriod
        {
            get => _collaborateGracePeriod;
            set
            {
                CollaborateGracePeriodSpecified = true;
                _collaborateGracePeriod = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateGracePeriodSpecified { get; set; }

        protected bool _enableActiveCollaborateNotification;

        [XmlElement(ElementName = "enableActiveCollaborateNotification", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        public bool EnableActiveCollaborateNotification
        {
            get => _enableActiveCollaborateNotification;
            set
            {
                EnableActiveCollaborateNotificationSpecified = true;
                _enableActiveCollaborateNotification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableActiveCollaborateNotificationSpecified { get; set; }

        protected string _collaborateFromAddress;

        [XmlElement(ElementName = "collaborateFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24834")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CollaborateFromAddress
        {
            get => _collaborateFromAddress;
            set
            {
                CollaborateFromAddressSpecified = true;
                _collaborateFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool CollaborateFromAddressSpecified { get; set; }

    }
}
