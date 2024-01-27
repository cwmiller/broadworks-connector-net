using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Available Out Of Office Configuration used in the context of a get.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de7795e1833d459a7eb89116d772fd78:129""}]")]
    public class CommPilotExpressAvailableOutOfOffice
    {

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        [Group(@"de7795e1833d459a7eb89116d772fd78:129")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection IncomingCalls
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

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify _incomingCallNotify;

        [XmlElement(ElementName = "incomingCallNotify", IsNullable = false, Namespace = "")]
        [Group(@"de7795e1833d459a7eb89116d772fd78:129")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify IncomingCallNotify
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
