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
    /// The response is either a ServiceProviderCallProcessingGetPolicyResponse17sp3 or an ErrorResponse.
    /// 
    /// Replaced by ServiceProviderCallProcessingGetPolicyResponse17sp4
    /// <see cref="ServiceProviderCallProcessingGetPolicyResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderCallProcessingGetPolicyResponse17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:18243""}]")]
    public class ServiceProviderCallProcessingGetPolicyRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderCallProcessingGetPolicyResponse17sp3>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:18243")]
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
