using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the service provider's DTMF based in-call service activation trigger attributes.The response is either a ServiceProviderInCallServiceActivationGetResponse or an ErrorResponse.
    /// Replaced by: ServiceProviderInCallServiceActivationGetRequest17
    /// <see cref="ServiceProviderInCallServiceActivationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderInCallServiceActivationGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19499""}]")]
    public class ServiceProviderInCallServiceActivationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderInCallServiceActivationGetResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19499")]
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

    }
}
