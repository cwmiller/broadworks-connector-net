using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Available In Office Configuration used in the context of a modify.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de7795e1833d459a7eb89116d772fd78:165""}]")]
    public class CommPilotExpressBusyModify
    {

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:165")]
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

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify _voiceMailNotify;

        [XmlElement(ElementName = "voiceMailNotify", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:165")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify VoiceMailNotify
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
