using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingAddConferenceRequest19.
    /// Contains the information of a conference.
    /// 
    /// Replaced by: UserMeetMeConferencingAddConferenceResponse23
    /// <see cref="UserMeetMeConferencingAddConferenceRequest19"/>
    /// <see cref="UserMeetMeConferencingAddConferenceResponse23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:45100""}]")]
    public class UserMeetMeConferencingAddConferenceResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _conferenceId;

        [XmlElement(ElementName = "conferenceId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45100")]
        [MinLength(6)]
        [MaxLength(12)]
        public string ConferenceId
        {
            get => _conferenceId;
            set
            {
                ConferenceIdSpecified = true;
                _conferenceId = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceIdSpecified { get; set; }

        private string _moderatorPin;

        [XmlElement(ElementName = "moderatorPin", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45100")]
        [MinLength(6)]
        [MaxLength(12)]
        public string ModeratorPin
        {
            get => _moderatorPin;
            set
            {
                ModeratorPinSpecified = true;
                _moderatorPin = value;
            }
        }

        [XmlIgnore]
        protected bool ModeratorPinSpecified { get; set; }

        private string _securityPin;

        [XmlElement(ElementName = "securityPin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45100")]
        [MinLength(4)]
        [MaxLength(12)]
        public string SecurityPin
        {
            get => _securityPin;
            set
            {
                SecurityPinSpecified = true;
                _securityPin = value;
            }
        }

        [XmlIgnore]
        protected bool SecurityPinSpecified { get; set; }

    }
}
