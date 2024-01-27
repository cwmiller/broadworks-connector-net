using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Available In Office Configuration used in the context of a get.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de7795e1833d459a7eb89116d772fd78:153""}]")]
    public class CommPilotExpressBusy
    {

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithException _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Group(@"de7795e1833d459a7eb89116d772fd78:153")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithException IncomingCalls
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

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify _voiceMailNotify;

        [XmlElement(ElementName = "voiceMailNotify", IsNullable = false, Namespace = "")]
        [Group(@"de7795e1833d459a7eb89116d772fd78:153")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify VoiceMailNotify
        {
            get => _voiceMailNotify;
            set
            {
                VoiceMailNotifySpecified = true;
                _voiceMailNotify = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMailNotifySpecified { get; set; }

    }
}
