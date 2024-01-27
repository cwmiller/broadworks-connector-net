using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the announcement repository file information.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// announcementFileExternalId
    /// 
    /// The response is either UserAnnouncementFileGetResponse22 or ErrorResponse.
    /// <see cref="UserAnnouncementFileGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:704"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:705""}]}]")]
    public class UserAnnouncementFileGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserAnnouncementFileGetResponse22>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:705")]
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

        protected BroadWorksConnector.Ocip.Models.AnnouncementFileKey _announcementFileKey;

        [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:705")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileKey AnnouncementFileKey
        {
            get => _announcementFileKey;
            set
            {
                AnnouncementFileKeySpecified = true;
                _announcementFileKey = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileKeySpecified { get; set; }

        protected string _announcementFileExternalId;

        [XmlElement(ElementName = "announcementFileExternalId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:704")]
        [MaxLength(36)]
        public string AnnouncementFileExternalId
        {
            get => _announcementFileExternalId;
            set
            {
                AnnouncementFileExternalIdSpecified = true;
                _announcementFileExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileExternalIdSpecified { get; set; }

    }
}
