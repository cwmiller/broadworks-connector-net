using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the service provider's voice portal passcode rules setting.
    /// The response is either ServiceProviderVoiceMessagingGroupGetPasscodeRulesResponse or ErrorResponse.
    /// Replaced By: ServiceProviderPortalPasscodeRulesGetRequest
    /// <see cref="ServiceProviderVoiceMessagingGroupGetPasscodeRulesResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderPortalPasscodeRulesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:19237""}]")]
    public class ServiceProviderVoiceMessagingGroupGetPasscodeRulesRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderVoiceMessagingGroupGetPasscodeRulesResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:19237")]
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
