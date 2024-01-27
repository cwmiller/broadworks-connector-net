using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add an announcement to the user announcement repository
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// announcementFileExternalId
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:498"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:500""}]}]")]
    public class UserAnnouncementFileAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:498")]
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

        protected string _announcementFileName;

        [XmlElement(ElementName = "announcementFileName", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:500")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AnnouncementFileName
        {
            get => _announcementFileName;
            set
            {
                AnnouncementFileNameSpecified = true;
                _announcementFileName = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileNameSpecified { get; set; }

        protected string _announcementFileExternalId;

        [XmlElement(ElementName = "announcementFileExternalId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:500")]
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _announcementFile;

        [XmlElement(ElementName = "announcementFile", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:498")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile
        {
            get => _announcementFile;
            set
            {
                AnnouncementFileSpecified = true;
                _announcementFile = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileSpecified { get; set; }

    }
}
