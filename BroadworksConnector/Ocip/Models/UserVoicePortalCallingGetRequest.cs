using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the user level data associated with Voice Portal Calling.
    /// The response is either a UserVoicePortalCallingGetResponse or an
    /// ErrorResponse.
    /// <see cref="UserVoicePortalCallingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23caf3c7f8f181bcb5b4719a3564ba94:42""}]")]
    public class UserVoicePortalCallingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoicePortalCallingGetResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"23caf3c7f8f181bcb5b4719a3564ba94:42")]
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
