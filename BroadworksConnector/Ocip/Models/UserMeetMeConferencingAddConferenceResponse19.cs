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
    /// <see cref="UserMeetMeConferencingAddConferenceRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:539""}]")]
    public class UserMeetMeConferencingAddConferenceResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _conferenceId;

        [XmlElement(ElementName = "conferenceId", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:539")]
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
        public bool ConferenceIdSpecified { get; set; }

        private string _moderatorPin;

        [XmlElement(ElementName = "moderatorPin", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:539")]
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
        public bool ModeratorPinSpecified { get; set; }

        private string _securityPin;

        [XmlElement(ElementName = "securityPin", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:539")]
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
        public bool SecurityPinSpecified { get; set; }

    }
}
