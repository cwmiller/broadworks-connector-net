using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging outgoing SMDI message waiting indicator service setting.
    /// The response is either a UserVoiceMessagingUserGetOutgoingSMDIMWIResponse or an ErrorResponse.
    /// <see cref="UserVoiceMessagingUserGetOutgoingSMDIMWIResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1863""}]")]
    public class UserVoiceMessagingUserGetOutgoingSMDIMWIRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoiceMessagingUserGetOutgoingSMDIMWIResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1863")]
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
