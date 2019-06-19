using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderVoiceMessagingGroupGetVoicePortalRequest.
    /// <see cref="ServiceProviderVoiceMessagingGroupGetVoicePortalRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:461""}]")]
    public class ServiceProviderVoiceMessagingGroupGetVoicePortalResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceProviderVoicePortalScope _voicePortalScope;

        [XmlElement(ElementName = "voicePortalScope", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:461")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderVoicePortalScope VoicePortalScope
        {
            get => _voicePortalScope;
            set
            {
                VoicePortalScopeSpecified = true;
                _voicePortalScope = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalScopeSpecified { get; set; }

    }
}
