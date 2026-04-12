using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal personal assistant menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:2790""}]")]
    public class PersonalAssistantMenuKeysReadEntry
    {

        protected string _setPresenceToNone;

        [XmlElement(ElementName = "setPresenceToNone", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToNone
        {
            get => _setPresenceToNone;
            set
            {
                SetPresenceToNoneSpecified = (value != null);
                _setPresenceToNone = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToNoneSpecified { get; set; }

        protected string _setPresenceToBusinessTrip;

        [XmlElement(ElementName = "setPresenceToBusinessTrip", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToBusinessTrip
        {
            get => _setPresenceToBusinessTrip;
            set
            {
                SetPresenceToBusinessTripSpecified = (value != null);
                _setPresenceToBusinessTrip = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToBusinessTripSpecified { get; set; }

        protected string _setPresenceToGoneForTheDay;

        [XmlElement(ElementName = "setPresenceToGoneForTheDay", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToGoneForTheDay
        {
            get => _setPresenceToGoneForTheDay;
            set
            {
                SetPresenceToGoneForTheDaySpecified = (value != null);
                _setPresenceToGoneForTheDay = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToGoneForTheDaySpecified { get; set; }

        protected string _setPresenceToLunch;

        [XmlElement(ElementName = "setPresenceToLunch", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToLunch
        {
            get => _setPresenceToLunch;
            set
            {
                SetPresenceToLunchSpecified = (value != null);
                _setPresenceToLunch = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToLunchSpecified { get; set; }

        protected string _setPresenceToMeeting;

        [XmlElement(ElementName = "setPresenceToMeeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToMeeting
        {
            get => _setPresenceToMeeting;
            set
            {
                SetPresenceToMeetingSpecified = (value != null);
                _setPresenceToMeeting = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToMeetingSpecified { get; set; }

        protected string _setPresenceToOutOfOffice;

        [XmlElement(ElementName = "setPresenceToOutOfOffice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToOutOfOffice
        {
            get => _setPresenceToOutOfOffice;
            set
            {
                SetPresenceToOutOfOfficeSpecified = (value != null);
                _setPresenceToOutOfOffice = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToOutOfOfficeSpecified { get; set; }

        protected string _setPresenceToTemporarilyOut;

        [XmlElement(ElementName = "setPresenceToTemporarilyOut", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToTemporarilyOut
        {
            get => _setPresenceToTemporarilyOut;
            set
            {
                SetPresenceToTemporarilyOutSpecified = (value != null);
                _setPresenceToTemporarilyOut = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToTemporarilyOutSpecified { get; set; }

        protected string _setPresenceToTraining;

        [XmlElement(ElementName = "setPresenceToTraining", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToTraining
        {
            get => _setPresenceToTraining;
            set
            {
                SetPresenceToTrainingSpecified = (value != null);
                _setPresenceToTraining = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToTrainingSpecified { get; set; }

        protected string _setPresenceToUnavailable;

        [XmlElement(ElementName = "setPresenceToUnavailable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToUnavailable
        {
            get => _setPresenceToUnavailable;
            set
            {
                SetPresenceToUnavailableSpecified = (value != null);
                _setPresenceToUnavailable = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToUnavailableSpecified { get; set; }

        protected string _setPresenceToVacation;

        [XmlElement(ElementName = "setPresenceToVacation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetPresenceToVacation
        {
            get => _setPresenceToVacation;
            set
            {
                SetPresenceToVacationSpecified = (value != null);
                _setPresenceToVacation = value;
            }
        }

        [XmlIgnore]
        protected bool SetPresenceToVacationSpecified { get; set; }

        protected string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
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

        protected string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2790")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = (value != null);
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

    }
}
