using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the Service Provider level data associated with Dial Plan Policy.
    /// The response is either a ServiceProviderDialPlanPolicyGetResponse17
    /// or an ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderDialPlanPolicyGetRequest22 in AS data mode.
    /// <see cref="ServiceProviderDialPlanPolicyGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderDialPlanPolicyGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:5636""}]")]
    public class ServiceProviderDialPlanPolicyGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderDialPlanPolicyGetResponse17>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:5636")]
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
