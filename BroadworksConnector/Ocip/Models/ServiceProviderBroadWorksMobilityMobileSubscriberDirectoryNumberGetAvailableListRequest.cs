using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of available Mobile Subscriber Directory Numbers not yet assigned to any group. This command is applicable only for service providers and will fail for enterprises.
    /// The response is either ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse or ErrorResponse.
    /// <see cref="ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:577""}]")]
    public class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:577")]
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
