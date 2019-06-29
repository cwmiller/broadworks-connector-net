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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8c204d784d1904d9eeea996d46de69be:165""}]")]
    public class CommPilotExpressBusyModify
    {

        private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionWithExceptionModify _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:165")]
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

        private BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify _voiceMailNotify;

        [XmlElement(ElementName = "voiceMailNotify", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:165")]
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
