using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingGetConferenceGreetingRequest.
    /// Contains the information of a conference custom greeting.
    /// <see cref="UserMeetMeConferencingGetConferenceGreetingRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:45135""}]")]
    public class UserMeetMeConferencingGetConferenceGreetingResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _playEntranceGreeting;

        [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45135")]
        public bool PlayEntranceGreeting
        {
            get => _playEntranceGreeting;
            set
            {
                PlayEntranceGreetingSpecified = true;
                _playEntranceGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool PlayEntranceGreetingSpecified { get; set; }

        private string _entranceGreetingAudioFile;

        [XmlElement(ElementName = "entranceGreetingAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45135")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceGreetingAudioFile
        {
            get => _entranceGreetingAudioFile;
            set
            {
                EntranceGreetingAudioFileSpecified = true;
                _entranceGreetingAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceGreetingAudioFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaFileType _entranceGreetingMediaType;

        [XmlElement(ElementName = "entranceGreetingMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45135")]
        public BroadWorksConnector.Ocip.Models.MediaFileType EntranceGreetingMediaType
        {
            get => _entranceGreetingMediaType;
            set
            {
                EntranceGreetingMediaTypeSpecified = true;
                _entranceGreetingMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceGreetingMediaTypeSpecified { get; set; }

    }
}
