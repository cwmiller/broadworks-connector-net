using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the reseller level data associated with Voice Messaging.
    /// The response is either a ResellerVoiceMessagingGroupGetResponse or an
    /// ErrorResponse.
    /// <see cref="ResellerVoiceMessagingGroupGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:322""}]")]
    public class ResellerVoiceMessagingGroupGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ResellerVoiceMessagingGroupGetResponse>
    {

        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:322")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

    }
}
