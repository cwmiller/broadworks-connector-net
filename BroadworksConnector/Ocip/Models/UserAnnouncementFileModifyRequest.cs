using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This command is used to change the name of the file or upload a new announcement file for
    /// an existing announcement in the user repository.
    /// When modifying the file type the command will fail if the media type of the new file changes
    /// the announcement from audio to video (or vice versa).
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:763"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:764"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:765""}]}]}]")]
    public class UserAnnouncementFileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:765")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:765")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:764")]
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

        protected string _newAnnouncementFileName;

        [XmlElement(ElementName = "newAnnouncementFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:763")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NewAnnouncementFileName
        {
            get => _newAnnouncementFileName;
            set
            {
                NewAnnouncementFileNameSpecified = true;
                _newAnnouncementFileName = value;
            }
        }

        [XmlIgnore]
        protected bool NewAnnouncementFileNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _announcementFile;

        [XmlElement(ElementName = "announcementFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:763")]
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
