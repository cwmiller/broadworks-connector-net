using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the service provider level data associated with Call Processing
    /// Policy.
    /// The response is either a ServiceProviderCallProcessingGetPolicyResponse15 or an ErrorResponse.
    /// Replaced By: ServiceProviderCallProcessingGetPolicyRequest16
    /// <see cref="ServiceProviderCallProcessingGetPolicyResponse15"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderCallProcessingGetPolicyRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:18156""}]")]
    public class ServiceProviderCallProcessingGetPolicyRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderCallProcessingGetPolicyResponse15>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:18156")]
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
