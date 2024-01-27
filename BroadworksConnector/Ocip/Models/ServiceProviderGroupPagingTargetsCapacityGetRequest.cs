using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the maximum number of target users per paging group configured for a service provider.
    /// The response is either a ServiceProviderGroupPagingTargetsCapacityGetResponse
    /// or an ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderGroupPagingTargetsCapacityGetRequest22 in AS data mode.
    /// <see cref="ServiceProviderGroupPagingTargetsCapacityGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderGroupPagingTargetsCapacityGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:6860""}]")]
    public class ServiceProviderGroupPagingTargetsCapacityGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderGroupPagingTargetsCapacityGetResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:6860")]
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
