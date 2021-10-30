using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a system voice portal instance.
    /// The response is either SystemSystemVoicePortalGetResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemSystemVoicePortalGetRequest21sp1.
    /// <see cref="SystemSystemVoicePortalGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSystemVoicePortalGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35351""}]")]
    public class SystemSystemVoicePortalGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSystemVoicePortalGetResponse>
    {

        private string _systemVoicePortalId;

        [XmlElement(ElementName = "systemVoicePortalId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:35351")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SystemVoicePortalId
        {
            get => _systemVoicePortalId;
            set
            {
                SystemVoicePortalIdSpecified = true;
                _systemVoicePortalId = value;
            }
        }

        [XmlIgnore]
        protected bool SystemVoicePortalIdSpecified { get; set; }

    }
}
