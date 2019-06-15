using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifier for conference.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MeetMeConferencingConferenceKey 
    {

        
        private string _bridgeId;

        [XmlElement(ElementName = "bridgeId", IsNullable = false, Namespace = "")]
        public string BridgeId {
            get => _bridgeId;
            set {
                BridgeIdSpecified = true;
                _bridgeId = value;
            }
        }

        [XmlIgnore]
        public bool BridgeIdSpecified { get; set; }
        
        private string _conferenceId;

        [XmlElement(ElementName = "conferenceId", IsNullable = false, Namespace = "")]
        public string ConferenceId {
            get => _conferenceId;
            set {
                ConferenceIdSpecified = true;
                _conferenceId = value;
            }
        }

        [XmlIgnore]
        public bool ConferenceIdSpecified { get; set; }
        
    }
}
