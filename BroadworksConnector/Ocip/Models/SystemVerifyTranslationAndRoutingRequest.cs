using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents a Verify Translation and Routing request which can be either a request containing
    /// parameters or a request containing a SIP message. The response is a SystemVerifyTranslationAndRoutingResponse.
    /// <see cref="SystemVerifyTranslationAndRoutingResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18032""}]")]
    public class SystemVerifyTranslationAndRoutingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingParameters _parameters;

        [XmlElement(ElementName = "parameters", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18032")]
        public BroadWorksConnector.Ocip.Models.VerifyTranslationAndRoutingParameters Parameters
        {
            get => _parameters;
            set
            {
                ParametersSpecified = true;
                _parameters = value;
            }
        }

        [XmlIgnore]
        protected bool ParametersSpecified { get; set; }

        private string _sipMessage;

        [XmlElement(ElementName = "sipMessage", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18032")]
        public string SipMessage
        {
            get => _sipMessage;
            set
            {
                SipMessageSpecified = true;
                _sipMessage = value;
            }
        }

        [XmlIgnore]
        protected bool SipMessageSpecified { get; set; }

    }
}
