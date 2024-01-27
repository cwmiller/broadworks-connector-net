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
    /// The response is either a ServiceProviderCallProcessingGetPolicyResponse18sp1 or an ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderCallProcessingGetPolicyRequest19sp1
    /// <see cref="ServiceProviderCallProcessingGetPolicyResponse18sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderCallProcessingGetPolicyRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:18281""}]")]
    public class ServiceProviderCallProcessingGetPolicyRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderCallProcessingGetPolicyResponse18sp1>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:18281")]
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
