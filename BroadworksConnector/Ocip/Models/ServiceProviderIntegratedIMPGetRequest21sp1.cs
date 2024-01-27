using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Integrated IMP service attributes for the service provider.
    /// The response is either ServiceProviderIntegratedIMPGetResponse21sp1 or ErrorResponse.
    /// 
    /// Replaced by: ServiceProviderIntegratedIMPGetRequest22 in AS data mode
    /// <see cref="ServiceProviderIntegratedIMPGetResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderIntegratedIMPGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:6949""}]")]
    public class ServiceProviderIntegratedIMPGetRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderIntegratedIMPGetResponse21sp1>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:6949")]
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
