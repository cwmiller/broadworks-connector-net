using System;
using System.Xml.Serialization;
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
     
    public class UserVoiceMessagingUserGetDistributionListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private int _listId;

        [XmlElement(ElementName = "listId", IsNullable = false, Namespace = "")]
        public int ListId {
            get => _listId;
            set {
                ListIdSpecified = true;
                _listId = value;
            }
        }

        [XmlIgnore]
        public bool ListIdSpecified { get; set; }
        
    }
}
