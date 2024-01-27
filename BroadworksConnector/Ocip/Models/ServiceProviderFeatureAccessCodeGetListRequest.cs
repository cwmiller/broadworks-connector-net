using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of feature access codes for a service provider or enterprise.
    /// The response is either a ServiceProviderFeatureAccessCodeGetListResponse or an ErrorResponse.
    /// 
    /// Replaced By : ServiceProviderFeatureAccessCodeGetListRequest20 in AS data mode
    /// <see cref="ServiceProviderFeatureAccessCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderFeatureAccessCodeGetListRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:6678""}]")]
    public class ServiceProviderFeatureAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderFeatureAccessCodeGetListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:6678")]
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
