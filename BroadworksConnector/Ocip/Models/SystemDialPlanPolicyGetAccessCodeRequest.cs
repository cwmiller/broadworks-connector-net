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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9228""}]")]
    public class SystemDialPlanPolicyGetAccessCodeRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDialPlanPolicyGetAccessCodeResponse>
    {

        protected string _accessCode;

        [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:9228")]
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
