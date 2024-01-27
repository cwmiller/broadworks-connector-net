using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the user's voice messaging greeting information.
    /// The response is either a UserVoiceMessagingUserGetGreetingResponse18sp1 or an ErrorResponse.
    /// 
    /// Replaced by: UserVoiceMessagingUserGetGreetingRequest20 in AS data mode
    /// <see cref="UserVoiceMessagingUserGetGreetingResponse18sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserVoiceMessagingUserGetGreetingRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9bff48d8661ff401ea11b6e32b924f02:416""}]")]
    public class UserVoiceMessagingUserGetGreetingRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoiceMessagingUserGetGreetingResponse18sp1>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"9bff48d8661ff401ea11b6e32b924f02:416")]
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
