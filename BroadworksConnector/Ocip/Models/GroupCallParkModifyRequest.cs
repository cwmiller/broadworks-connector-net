using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Group's Call Park settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:519""}]")]
    public class GroupCallParkModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
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
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
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

        private int _recallTimerSeconds;

        [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int RecallTimerSeconds
        {
            get => _recallTimerSeconds;
            set
            {
                RecallTimerSecondsSpecified = true;
                _recallTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RecallTimerSecondsSpecified { get; set; }

        private int _displayTimerSeconds;

        [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
        [MinInclusive(2)]
        [MaxInclusive(15)]
        public int DisplayTimerSeconds
        {
            get => _displayTimerSeconds;
            set
            {
                DisplayTimerSecondsSpecified = true;
                _displayTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DisplayTimerSecondsSpecified { get; set; }

        private bool _enableDestinationAnnouncement;

        [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
        public bool EnableDestinationAnnouncement
        {
            get => _enableDestinationAnnouncement;
            set
            {
                EnableDestinationAnnouncementSpecified = true;
                _enableDestinationAnnouncement = value;
            }
        }

        [XmlIgnore]
        public bool EnableDestinationAnnouncementSpecified { get; set; }

        private string _recallAlternateUserId;

        [XmlElement(ElementName = "recallAlternateUserId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
        [MinLength(1)]
        [MaxLength(161)]
        public string RecallAlternateUserId
        {
            get => _recallAlternateUserId;
            set
            {
                RecallAlternateUserIdSpecified = true;
                _recallAlternateUserId = value;
            }
        }

        [XmlIgnore]
        public bool RecallAlternateUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RingPattern _recallRingPattern;

        [XmlElement(ElementName = "recallRingPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
        public BroadWorksConnector.Ocip.Models.RingPattern RecallRingPattern
        {
            get => _recallRingPattern;
            set
            {
                RecallRingPatternSpecified = true;
                _recallRingPattern = value;
            }
        }

        [XmlIgnore]
        public bool RecallRingPatternSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallParkRecallTo _recallTo;

        [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
        public BroadWorksConnector.Ocip.Models.CallParkRecallTo RecallTo
        {
            get => _recallTo;
            set
            {
                RecallToSpecified = true;
                _recallTo = value;
            }
        }

        [XmlIgnore]
        public bool RecallToSpecified { get; set; }

        private int _alternateUserRecallTimerSeconds;

        [XmlElement(ElementName = "alternateUserRecallTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:519")]
        [MinInclusive(30)]
        [MaxInclusive(600)]
        public int AlternateUserRecallTimerSeconds
        {
            get => _alternateUserRecallTimerSeconds;
            set
            {
                AlternateUserRecallTimerSecondsSpecified = true;
                _alternateUserRecallTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool AlternateUserRecallTimerSecondsSpecified { get; set; }

    }
}
