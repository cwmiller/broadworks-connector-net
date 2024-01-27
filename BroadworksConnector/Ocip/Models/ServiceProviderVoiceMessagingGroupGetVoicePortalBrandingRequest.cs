using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider's voice portal branding settings.
    /// The response is either a ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse or an ErrorResponse.
    /// Replaced By: ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16
    /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19941""}]")]
    public class ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19941")]
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
