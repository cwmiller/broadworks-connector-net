using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:36255""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14>
    {

        private bool _getDefaultMenuKeys;

        [XmlElement(ElementName = "getDefaultMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:36255")]
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
