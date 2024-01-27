using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalAssistantGetRequest24.
    /// The response contains the user Personal Assistant information and a table of Schedule Selective Criteria entries.
    /// The schedule table's column headings are: "Is Active", "Criteria Name", "Time Schedule", "Holiday Schedule",
    /// "Presence", "Transfer to Attendant", "Attendant Number", "Play Ring Splash", "Alert Me First", "Number of Rings".
    /// <see cref="UserPersonalAssistantGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bd221784ebf8af2fe1169d36a6ac2dd:410""}]")]
    public class UserPersonalAssistantGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.PersonalAssistantPresence _presence;

        [XmlElement(ElementName = "presence", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
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
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
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
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
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
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
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

        protected bool _enableExpirationTime;

        [XmlElement(ElementName = "enableExpirationTime", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
        public bool EnableExpirationTime
        {
            get => _enableExpirationTime;
            set
            {
                EnableExpirationTimeSpecified = true;
                _enableExpirationTime = value;
            }
        }

        [XmlIgnore]
        protected bool EnableExpirationTimeSpecified { get; set; }

        protected string _expirationTime;

        [XmlElement(ElementName = "expirationTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
        public string ExpirationTime
        {
            get => _expirationTime;
            set
            {
                ExpirationTimeSpecified = true;
                _expirationTime = value;
            }
        }

        [XmlIgnore]
        protected bool ExpirationTimeSpecified { get; set; }

        protected bool _alertMeFirst;

        [XmlElement(ElementName = "alertMeFirst", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
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
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _scheduleTable;

        [XmlElement(ElementName = "scheduleTable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:410")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ScheduleTable
        {
            get => _scheduleTable;
            set
            {
                ScheduleTableSpecified = true;
                _scheduleTable = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleTableSpecified { get; set; }

    }
}
