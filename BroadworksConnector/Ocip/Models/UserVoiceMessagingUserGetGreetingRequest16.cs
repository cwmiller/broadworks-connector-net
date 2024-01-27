using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging greeting information.
    /// The response is either a UserVoiceMessagingUserGetGreetingResponse16 or an ErrorResponse.
    /// 
    /// Replaced by: UserVoiceMessagingUserGetGreetingRequest18
    /// <see cref="UserVoiceMessagingUserGetGreetingResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserVoiceMessagingUserGetGreetingRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:47898""}]")]
    public class UserVoiceMessagingUserGetGreetingRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoiceMessagingUserGetGreetingResponse16>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:47898")]
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
