using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemInCallServiceActivationGetRequest.
    /// Replaced by: SystemInCallServiceActivationGetResponse17
    /// <see cref="SystemInCallServiceActivationGetRequest"/>
    /// <see cref="SystemInCallServiceActivationGetResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27796""}]")]
    public class SystemInCallServiceActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultActivationDigits;

        [XmlElement(ElementName = "defaultActivationDigits", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27796")]
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
