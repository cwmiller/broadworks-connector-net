using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Available Out Of Office Configuration used in the context of a modify.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8c204d784d1904d9eeea996d46de69be:141""}]")]
    public class CommPilotExpressAvailableOutOfOfficeModify
    {

        private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:141")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify IncomingCalls
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

        private BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify _incomingCallNotify;

        [XmlElement(ElementName = "incomingCallNotify", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:141")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify IncomingCallNotify
        {
            get => _incomingCallNotify;
            set
            {
                IncomingCallNotifySpecified = true;
                _incomingCallNotify = value;
            }
        }

        [XmlIgnore]
        protected bool IncomingCallNotifySpecified { get; set; }

    }
}
