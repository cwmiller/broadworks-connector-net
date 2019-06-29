using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallParkGetRequest16sp2.
    /// Contains the settings that apply to the whole group for Call Park.
    /// <see cref="GroupCallParkGetRequest16sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:474""}]")]
    public class GroupCallParkGetResponse16sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _recallTimerSeconds;

        [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:474")]
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
        protected bool RecallTimerSecondsSpecified { get; set; }

        private int _displayTimerSeconds;

        [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:474")]
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
        protected bool DisplayTimerSecondsSpecified { get; set; }

        private bool _enableDestinationAnnouncement;

        [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:474")]
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
        protected bool EnableDestinationAnnouncementSpecified { get; set; }

        private string _recallAlternateUserId;

        [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:474")]
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
        protected bool RecallAlternateUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RingPattern _recallRingPattern;

        [XmlElement(ElementName = "recallRingPattern", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:474")]
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
        protected bool RecallRingPatternSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallParkRecallTo _recallTo;

        [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:474")]
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
        protected bool RecallToSpecified { get; set; }

        private int _alternateUserRecallTimerSeconds;

        [XmlElement(ElementName = "alternateUserRecallTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:474")]
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
        protected bool AlternateUserRecallTimerSecondsSpecified { get; set; }

    }
}
