using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a voice mail distribution list for a users voice message.
    /// The response is either UserVoiceMessagingUserGetDistributionListResponse or ErrorResponse.
    /// <see cref="UserVoiceMessagingUserGetDistributionListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1772""}]")]
    public class UserVoiceMessagingUserGetDistributionListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserVoiceMessagingUserGetDistributionListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1772")]
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

        protected int _listId;

        [XmlElement(ElementName = "listId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1772")]
        [MinInclusive(0)]
        [MaxInclusive(14)]
        public int ListId
        {
            get => _listId;
            set
            {
                ListIdSpecified = true;
                _listId = value;
            }
        }

        [XmlIgnore]
        protected bool ListIdSpecified { get; set; }

    }
}
