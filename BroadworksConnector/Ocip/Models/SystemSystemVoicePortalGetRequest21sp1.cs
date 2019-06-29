using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a system voice portal instance.
    /// The response is either SystemSystemVoicePortalGetResponse21sp1 or ErrorResponse.
    /// <see cref="SystemSystemVoicePortalGetResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17432""}]")]
    public class SystemSystemVoicePortalGetRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _systemVoicePortalId;

        [XmlElement(ElementName = "systemVoicePortalId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17432")]
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
