using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system voice portal Menus setting.
    /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse19 or ErrorResponse.
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1
        /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse19"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemVoiceMessagingGroupGetVoicePortalMenusRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
