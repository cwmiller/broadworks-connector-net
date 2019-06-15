using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifier for conference recording. startTime is the recording start timestamp.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MeetMeConferencingConferenceRecordingKey 
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
        
        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        public string StartTime {
            get => _startTime;
            set {
                StartTimeSpecified = true;
                _startTime = value;
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified { get; set; }
        
    }
}
