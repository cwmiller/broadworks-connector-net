using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the system voice portal Menus setting.
    /// The response is either SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1 or ErrorResponse.
    /// 
    /// Replaced by SystemVoiceMessagingGroupGetVoicePortalMenusRequest20
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemVoiceMessagingGroupGetVoicePortalMenusRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:37084""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1>
    {

        protected bool _getDefaultMenuKeys;

        [XmlElement(ElementName = "getDefaultMenuKeys", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:37084")]
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
