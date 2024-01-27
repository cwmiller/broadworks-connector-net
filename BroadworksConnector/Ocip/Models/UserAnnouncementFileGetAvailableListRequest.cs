using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of available announcement files for a User from the Announcement Repository,
    /// for Virtual subscribers the list will also include the announcements for it's group.
    /// The response is either a UserAnnouncementFileGetAvailableListResponse or ErrorResponse
    /// <see cref="UserAnnouncementFileGetAvailableListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:544""}]")]
    public class UserAnnouncementFileGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserAnnouncementFileGetAvailableListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:544")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileType _announcementFileType;

        [XmlElement(ElementName = "announcementFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:544")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileType AnnouncementFileType
        {
            get => _announcementFileType;
            set
            {
                AnnouncementFileTypeSpecified = true;
                _announcementFileType = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileTypeSpecified { get; set; }

    }
}
