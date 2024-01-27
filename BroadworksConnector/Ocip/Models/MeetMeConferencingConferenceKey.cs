using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifier for conference.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:3493""}]")]
    public class MeetMeConferencingConferenceKey
    {

        protected string _bridgeId;

        [XmlElement(ElementName = "bridgeId", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3493")]
        [MinLength(1)]
        [MaxLength(161)]
        public string BridgeId
        {
            get => _bridgeId;
            set
            {
                BridgeIdSpecified = true;
                _bridgeId = value;
            }
        }

        [XmlIgnore]
        protected bool BridgeIdSpecified { get; set; }

        protected string _conferenceId;

        [XmlElement(ElementName = "conferenceId", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:3493")]
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

    }
}
