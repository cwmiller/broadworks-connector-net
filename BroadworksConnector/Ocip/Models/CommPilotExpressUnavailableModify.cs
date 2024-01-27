using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Unavailable Configuration used in the context of a modify.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de7795e1833d459a7eb89116d772fd78:271""}]")]
    public class CommPilotExpressUnavailableModify
    {

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:271")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify IncomingCalls
        {
            get => _incomingCalls;
            set
            {
                IncomingCallsSpecified = true;
                _incomingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IncomingCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting _voiceMailGreeting;

        [XmlElement(ElementName = "voiceMailGreeting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:271")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressVoiceMailGreeting VoiceMailGreeting
        {
            get => _voiceMailGreeting;
            set
            {
                VoiceMailGreetingSpecified = true;
                _voiceMailGreeting = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMailGreetingSpecified { get; set; }

    }
}
