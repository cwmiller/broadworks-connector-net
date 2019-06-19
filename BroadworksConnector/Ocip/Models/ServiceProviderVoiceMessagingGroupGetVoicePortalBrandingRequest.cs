using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the service provider's voice portal branding settings.
    /// The response is either a ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse or an
    /// ErrorResponse.
    /// Replaced By: ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16
    /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9833""}]")]
    public class ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9833")]
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
        public bool ServiceProviderIdSpecified { get; set; }

    }
}
