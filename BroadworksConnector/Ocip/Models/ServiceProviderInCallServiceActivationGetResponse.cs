using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderInCallServiceActivationGetRequest.
    /// 
    /// Replaced by: ServiceProviderInCallServiceActivationGetResponse17
    /// <see cref="ServiceProviderInCallServiceActivationGetRequest"/>
    /// <see cref="ServiceProviderInCallServiceActivationGetResponse17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19516""}]")]
    public class ServiceProviderInCallServiceActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _activationDigits;

        [XmlElement(ElementName = "activationDigits", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19516")]
        [MinLength(1)]
        [MaxLength(8)]
        public string ActivationDigits
        {
            get => _activationDigits;
            set
            {
                ActivationDigitsSpecified = true;
                _activationDigits = value;
            }
        }

        [XmlIgnore]
        protected bool ActivationDigitsSpecified { get; set; }

    }
}
