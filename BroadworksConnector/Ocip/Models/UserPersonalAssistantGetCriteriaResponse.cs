using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalAssistantGetCriteriaRequest.
    /// <see cref="UserPersonalAssistantGetCriteriaRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bd221784ebf8af2fe1169d36a6ac2dd:369""}]")]
    public class UserPersonalAssistantGetCriteriaResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PersonalAssistantPresence _presence;

        [XmlElement(ElementName = "presence", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        public BroadWorksConnector.Ocip.Models.PersonalAssistantPresence Presence
        {
            get => _presence;
            set
            {
                PresenceSpecified = true;
                _presence = value;
            }
        }

        [XmlIgnore]
        protected bool PresenceSpecified { get; set; }

        protected bool _enableTransferToAttendant;

        [XmlElement(ElementName = "enableTransferToAttendant", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        public bool EnableTransferToAttendant
        {
            get => _enableTransferToAttendant;
            set
            {
                EnableTransferToAttendantSpecified = true;
                _enableTransferToAttendant = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTransferToAttendantSpecified { get; set; }

        protected string _attendantNumber;

        [XmlElement(ElementName = "attendantNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AttendantNumber
        {
            get => _attendantNumber;
            set
            {
                AttendantNumberSpecified = true;
                _attendantNumber = value;
            }
        }

        [XmlIgnore]
        protected bool AttendantNumberSpecified { get; set; }

        protected bool _enableRingSplash;

        [XmlElement(ElementName = "enableRingSplash", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        public bool EnableRingSplash
        {
            get => _enableRingSplash;
            set
            {
                EnableRingSplashSpecified = true;
                _enableRingSplash = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRingSplashSpecified { get; set; }

        protected bool _alertMeFirst;

        [XmlElement(ElementName = "alertMeFirst", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        public bool AlertMeFirst
        {
            get => _alertMeFirst;
            set
            {
                AlertMeFirstSpecified = true;
                _alertMeFirst = value;
            }
        }

        [XmlIgnore]
        protected bool AlertMeFirstSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.PersonalAssistantAlertMeFirstNumberOfRings _alertMeFirstNumberOfRings;

        [XmlElement(ElementName = "alertMeFirstNumberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:369")]
        public BroadWorksConnector.Ocip.Models.PersonalAssistantAlertMeFirstNumberOfRings AlertMeFirstNumberOfRings
        {
            get => _alertMeFirstNumberOfRings;
            set
            {
                AlertMeFirstNumberOfRingsSpecified = true;
                _alertMeFirstNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool AlertMeFirstNumberOfRingsSpecified { get; set; }

    }
}
