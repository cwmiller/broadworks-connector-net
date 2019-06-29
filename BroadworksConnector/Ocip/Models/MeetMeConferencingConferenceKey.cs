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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2542""}]")]
    public class MeetMeConferencingConferenceKey
    {

        private string _bridgeId;

        [XmlElement(ElementName = "bridgeId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2542")]
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

        private string _conferenceId;

        [XmlElement(ElementName = "conferenceId", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2542")]
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
