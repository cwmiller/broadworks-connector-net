using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1628""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalAssistantMenuKeys
    {

        private string _setPresenceToNone;

        [XmlElement(ElementName = "setPresenceToNone", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToNone
        {
            get => _setPresenceToNone;
            set
            {
                SetPresenceToNoneSpecified = true;
                _setPresenceToNone = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToNoneSpecified { get; set; }

        private string _setPresenceToBusinessTrip;

        [XmlElement(ElementName = "setPresenceToBusinessTrip", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToBusinessTrip
        {
            get => _setPresenceToBusinessTrip;
            set
            {
                SetPresenceToBusinessTripSpecified = true;
                _setPresenceToBusinessTrip = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToBusinessTripSpecified { get; set; }

        private string _setPresenceToGoneForTheDay;

        [XmlElement(ElementName = "setPresenceToGoneForTheDay", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToGoneForTheDay
        {
            get => _setPresenceToGoneForTheDay;
            set
            {
                SetPresenceToGoneForTheDaySpecified = true;
                _setPresenceToGoneForTheDay = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToGoneForTheDaySpecified { get; set; }

        private string _setPresenceToLunch;

        [XmlElement(ElementName = "setPresenceToLunch", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToLunch
        {
            get => _setPresenceToLunch;
            set
            {
                SetPresenceToLunchSpecified = true;
                _setPresenceToLunch = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToLunchSpecified { get; set; }

        private string _setPresenceToMeeting;

        [XmlElement(ElementName = "setPresenceToMeeting", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToMeeting
        {
            get => _setPresenceToMeeting;
            set
            {
                SetPresenceToMeetingSpecified = true;
                _setPresenceToMeeting = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToMeetingSpecified { get; set; }

        private string _setPresenceToOutOfOffice;

        [XmlElement(ElementName = "setPresenceToOutOfOffice", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToOutOfOffice
        {
            get => _setPresenceToOutOfOffice;
            set
            {
                SetPresenceToOutOfOfficeSpecified = true;
                _setPresenceToOutOfOffice = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToOutOfOfficeSpecified { get; set; }

        private string _setPresenceToTemporarilyOut;

        [XmlElement(ElementName = "setPresenceToTemporarilyOut", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToTemporarilyOut
        {
            get => _setPresenceToTemporarilyOut;
            set
            {
                SetPresenceToTemporarilyOutSpecified = true;
                _setPresenceToTemporarilyOut = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToTemporarilyOutSpecified { get; set; }

        private string _setPresenceToTraining;

        [XmlElement(ElementName = "setPresenceToTraining", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToTraining
        {
            get => _setPresenceToTraining;
            set
            {
                SetPresenceToTrainingSpecified = true;
                _setPresenceToTraining = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToTrainingSpecified { get; set; }

        private string _setPresenceToUnavailable;

        [XmlElement(ElementName = "setPresenceToUnavailable", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToUnavailable
        {
            get => _setPresenceToUnavailable;
            set
            {
                SetPresenceToUnavailableSpecified = true;
                _setPresenceToUnavailable = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToUnavailableSpecified { get; set; }

        private string _setPresenceToVacation;

        [XmlElement(ElementName = "setPresenceToVacation", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToVacation
        {
            get => _setPresenceToVacation;
            set
            {
                SetPresenceToVacationSpecified = true;
                _setPresenceToVacation = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToVacationSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReturnToPreviousMenu
        {
            get => _returnToPreviousMenu;
            set
            {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        protected bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1628")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

    }
}
