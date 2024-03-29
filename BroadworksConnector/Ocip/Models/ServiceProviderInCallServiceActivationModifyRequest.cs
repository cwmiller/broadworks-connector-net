using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the service provider's DTMF based in-call service activation trigger attributes.The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced by: ServiceProviderInCallServiceActivationModifyRequest17
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderInCallServiceActivationModifyRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19532""}]")]
    public class ServiceProviderInCallServiceActivationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19532")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _activationDigits;

        [XmlElement(ElementName = "activationDigits", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:19532")]
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
