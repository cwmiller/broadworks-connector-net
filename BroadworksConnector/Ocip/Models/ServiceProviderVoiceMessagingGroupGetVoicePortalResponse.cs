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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:461""}]")]
    public class ServiceProviderVoiceMessagingGroupGetVoicePortalResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ServiceProviderVoicePortalScope _voicePortalScope;

        [XmlElement(ElementName = "voicePortalScope", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:461")]
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
        protected bool VoicePortalScopeSpecified { get; set; }

    }
}
