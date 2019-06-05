using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CommPilotExpressBusy
    {
        private BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionWithException _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionWithException IncomingCalls
        {
            get => _incomingCalls;
            set
            {
                IncomingCallsSpecified = true;
                _incomingCalls = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallsSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CommPilotExpressEmailNotify _voiceMailNotify;

        [XmlElement(ElementName = "voiceMailNotify", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommPilotExpressEmailNotify VoiceMailNotify
        {
            get => _voiceMailNotify;
            set
            {
                VoiceMailNotifySpecified = true;
                _voiceMailNotify = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMailNotifySpecified { get; set; }
    }
}
