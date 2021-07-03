using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request access code data associated with system level Dial Plan Policy access codes.
    /// The response is either a SystemDialPlanPolicyGetAccessCodeResponse or an ErrorResponse.
    /// <see cref="SystemDialPlanPolicyGetAccessCodeResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9104""}]")]
    public class SystemDialPlanPolicyGetAccessCodeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _accessCode;

        [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9104")]
        [MinLength(1)]
        [MaxLength(5)]
        public string AccessCode
        {
            get => _accessCode;
            set
            {
                AccessCodeSpecified = true;
                _accessCode = value;
            }
        }

        [XmlIgnore]
        protected bool AccessCodeSpecified { get; set; }

    }
}
