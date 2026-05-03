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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:50006""}]")]
    public class UserMeetMeConferencingGetConferenceGreetingResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _playEntranceGreeting;

        [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:50006")]
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

        protected string _entranceGreetingAudioFile;

        [XmlElement(ElementName = "entranceGreetingAudioFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:50006")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EntranceGreetingAudioFile
        {
            get => _entranceGreetingAudioFile;
            set
            {
                EntranceGreetingAudioFileSpecified = (value != null);
                _entranceGreetingAudioFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceGreetingAudioFileSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaFileType? _entranceGreetingMediaType;

        [XmlElement(ElementName = "entranceGreetingMediaType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:50006")]
        public BroadWorksConnector.Ocip.Models.MediaFileType? EntranceGreetingMediaType
        {
            get => _entranceGreetingMediaType;
            set
            {
                EntranceGreetingMediaTypeSpecified = (value != null);
                _entranceGreetingMediaType = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceGreetingMediaTypeSpecified { get; set; }

    }
}
