using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system voice portal Menus setting.
    /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse18 or ErrorResponse.
    /// 
    /// Replaced by SystemVoiceMessagingGroupGetVoicePortalMenusRequest19
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse18"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:36273""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusRequest18 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _getDefaultMenuKeys;

        [XmlElement(ElementName = "getDefaultMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36273")]
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
