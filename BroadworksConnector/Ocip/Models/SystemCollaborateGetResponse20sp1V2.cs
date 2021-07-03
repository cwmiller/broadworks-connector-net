using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCollaborateGetRequest20sp1V2.
    /// <see cref="SystemCollaborateGetRequest20sp1V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:525""}]")]
    public class SystemCollaborateGetResponse20sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _collaborateRoomIdLength;

        [XmlElement(ElementName = "collaborateRoomIdLength", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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

        private int _instantRoomIdleTimeoutSeconds;

        [XmlElement(ElementName = "instantRoomIdleTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
        [MinInclusive(60)]
        [MaxInclusive(18000)]
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

        private int _collaborateRoomMaximumDurationMinutes;

        [XmlElement(ElementName = "collaborateRoomMaximumDurationMinutes", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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

        private bool _supportOutdial;

        [XmlElement(ElementName = "supportOutdial", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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

        private int _maxCollaborateRoomParticipants;

        [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
        [MinInclusive(3)]
        [MaxInclusive(145)]
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

        private int _collaborateActiveTalkerRefreshIntervalSeconds;

        [XmlElement(ElementName = "collaborateActiveTalkerRefreshIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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

        private bool _terminateCollaborateAfterGracePeriod;

        [XmlElement(ElementName = "terminateCollaborateAfterGracePeriod", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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

        private BroadWorksConnector.Ocip.Models.CollaborateGracePeriodDuration _collaborateGracePeriod;

        [XmlElement(ElementName = "collaborateGracePeriod", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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

        private bool _enableActiveCollaborateNotification;

        [XmlElement(ElementName = "enableActiveCollaborateNotification", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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

        private string _collaborateFromAddress;

        [XmlElement(ElementName = "collaborateFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:525")]
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
