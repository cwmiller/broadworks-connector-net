using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a list of all service pack migration task for a service provider.
    /// The response is either ServiceProviderServicePackMigrationTaskGetListResponse
    /// or ErrorResponse.
    /// 
    /// Replaced By: ServiceProviderServicePackMigrationTaskGetListRequest21 in AS data mode
    /// <see cref="ServiceProviderServicePackMigrationTaskGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderServicePackMigrationTaskGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:7261""}]")]
    public class ServiceProviderServicePackMigrationTaskGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderServicePackMigrationTaskGetListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:7261")]
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
