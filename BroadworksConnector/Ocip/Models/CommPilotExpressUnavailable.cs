using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Unavailable Configuration used in the context of a get.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CommPilotExpressUnavailable 
    {

        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithException _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithException IncomingCalls {
            get => _incomingCalls;
            set {
                IncomingCallsSpecified = true;
                _incomingCalls = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting _voiceMailGreeting;

        [XmlElement(ElementName = "voiceMailGreeting", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting VoiceMailGreeting {
            get => _voiceMailGreeting;
            set {
                VoiceMailGreetingSpecified = true;
                _voiceMailGreeting = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMailGreetingSpecified { get; set; }
        
    }
}
