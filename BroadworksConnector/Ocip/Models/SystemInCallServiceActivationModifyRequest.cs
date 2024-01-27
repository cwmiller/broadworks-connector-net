using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's DTMF based in-call service activation trigger  attributes.The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemInCallServiceActivationModifyRequest17
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemInCallServiceActivationModifyRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27812""}]")]
    public class SystemInCallServiceActivationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _defaultActivationDigits;

        [XmlElement(ElementName = "defaultActivationDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:27812")]
        [MinLength(1)]
        [MaxLength(8)]
        public string DefaultActivationDigits
        {
            get => _defaultActivationDigits;
            set
            {
                DefaultActivationDigitsSpecified = true;
                _defaultActivationDigits = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultActivationDigitsSpecified { get; set; }

    }
}
