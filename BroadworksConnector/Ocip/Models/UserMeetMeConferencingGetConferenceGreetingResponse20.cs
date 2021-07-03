using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMeetMeConferencingGetConferenceGreetingRequest20.
    /// Contains the information of a conference custom greeting.
    /// <see cref="UserMeetMeConferencingGetConferenceGreetingRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:733""}]")]
    public class UserMeetMeConferencingGetConferenceGreetingResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _playEntranceGreeting;

        [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:733")]
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

        private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _entranceGreetingFile;

        [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:733")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey EntranceGreetingFile
        {
            get => _entranceGreetingFile;
            set
            {
                EntranceGreetingFileSpecified = true;
                _entranceGreetingFile = value;
            }
        }

        [XmlIgnore]
        protected bool EntranceGreetingFileSpecified { get; set; }

    }
}
