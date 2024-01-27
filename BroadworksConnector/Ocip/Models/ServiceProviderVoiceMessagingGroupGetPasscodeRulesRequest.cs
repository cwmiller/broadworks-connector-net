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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:19895""}]")]
    public class ServiceProviderVoiceMessagingGroupGetPasscodeRulesRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderVoiceMessagingGroupGetPasscodeRulesResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:19895")]
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
