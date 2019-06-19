using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Third-Party Voice Mail Support.
    /// The response is either a UserThirdPartyVoiceMailSupportGetResponse17 or an
    /// ErrorResponse.
    /// <see cref="UserThirdPartyVoiceMailSupportGetResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3c311aa5c89c0cf5b46e1cdefd5bc387:242""}]")]
    public class UserThirdPartyVoiceMailSupportGetRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:242")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }

    }
}
