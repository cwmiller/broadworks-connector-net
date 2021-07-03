using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system voice portal Menus setting.
    /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse21 or ErrorResponse.
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:670""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _getDefaultMenuKeys;

        [XmlElement(ElementName = "getDefaultMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:670")]
        public bool GetDefaultMenuKeys
        {
            get => _getDefaultMenuKeys;
            set
            {
                GetDefaultMenuKeysSpecified = true;
                _getDefaultMenuKeys = value;
            }
        }

        [XmlIgnore]
        protected bool GetDefaultMenuKeysSpecified { get; set; }

    }
}
