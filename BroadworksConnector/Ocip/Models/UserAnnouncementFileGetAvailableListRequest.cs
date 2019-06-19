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
    /// The response is either UserAnnouncementFileGetAvailableListResponse or ErrorResponse
    /// <see cref="UserAnnouncementFileGetAvailableListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:513""}]")]
    public class UserAnnouncementFileGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:513")]
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

        private BroadWorksConnector.Ocip.Models.AnnouncementFileType _announcementFileType;

        [XmlElement(ElementName = "announcementFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:513")]
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
        public bool AnnouncementFileTypeSpecified { get; set; }

    }
}
