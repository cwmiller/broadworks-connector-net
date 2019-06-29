using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system voice portal Menus setting.
    /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1 or ErrorResponse.
    /// 
    /// Replaced by SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse18sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27088""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _getDefaultMenuKeys;

        [XmlElement(ElementName = "getDefaultMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:27088")]
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
