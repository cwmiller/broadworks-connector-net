using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express type to transfer to voice Mail or forward to a number
    /// used in the context of a get.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de7795e1833d459a7eb89116d772fd78:202""}]")]
    public class CommPilotExpressRedirection
    {

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"de7795e1833d459a7eb89116d772fd78:202")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        protected bool ActionSpecified { get; set; }

        protected string _forwardingPhoneNumber;

        [XmlElement(ElementName = "forwardingPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:202")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ForwardingPhoneNumber
        {
            get => _forwardingPhoneNumber;
            set
            {
                ForwardingPhoneNumberSpecified = true;
                _forwardingPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardingPhoneNumberSpecified { get; set; }

    }
}
