using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system voice portal Menus setting.
    /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse14 or ErrorResponse.
        /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse14"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupGetVoicePortalMenusRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _getDefaultMenuKeys;

        [XmlElement(ElementName = "getDefaultMenuKeys", IsNullable = false, Namespace = "")]
        public bool GetDefaultMenuKeys {
            get => _getDefaultMenuKeys;
            set {
                GetDefaultMenuKeysSpecified = true;
                _getDefaultMenuKeys = value;
            }
        }

        [XmlIgnore]
        public bool GetDefaultMenuKeysSpecified { get; set; }
        
    }
}
