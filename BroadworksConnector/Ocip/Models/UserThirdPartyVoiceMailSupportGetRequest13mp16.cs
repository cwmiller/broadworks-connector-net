using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Third-Party Voice Mail Support.
    /// The response is either a UserThirdPartyVoiceMailSupportGetResponse13mp16 or an
    /// ErrorResponse.
    /// Replaced by: UserThirdPartyVoiceMailSupportGetRequest17
    /// <see cref="UserThirdPartyVoiceMailSupportGetResponse13mp16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserThirdPartyVoiceMailSupportGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:46658""}]")]
    public class UserThirdPartyVoiceMailSupportGetRequest13mp16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserThirdPartyVoiceMailSupportGetResponse13mp16>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:46658")]
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
        protected bool UserIdSpecified { get; set; }

    }
}
