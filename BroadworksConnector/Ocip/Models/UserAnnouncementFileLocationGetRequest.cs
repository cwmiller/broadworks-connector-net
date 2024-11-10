using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the location of a file in a user’s Announcement Repository.
    /// The response is either UserAnnouncementFileLocationGetResponse or ErrorResponse.
        /// <see cref="UserAnnouncementFileLocationGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2bd2e9c0ba9fd02c495cbd673527444f:19""}]")]
    public class UserAnnouncementFileLocationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserAnnouncementFileLocationGetResponse>
    {
        
        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"2bd2e9c0ba9fd02c495cbd673527444f:19")]
[MinLength(1)]
[MaxLength(161)]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }
        
        protected BroadWorksConnector.Ocip.Models.AnnouncementFileKey _announcementFileKey;

        [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
        [Group(@"2bd2e9c0ba9fd02c495cbd673527444f:19")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey AnnouncementFileKey {
            get => _announcementFileKey;
            set {
                AnnouncementFileKeySpecified = true;
                _announcementFileKey = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileKeySpecified { get; set; }
        
    }
}
