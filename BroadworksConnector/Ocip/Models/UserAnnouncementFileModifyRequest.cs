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
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:706""}]")]
    public class UserAnnouncementFileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:706")]
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

        private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _announcementFileKey;

        [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:706")]
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
        public bool AnnouncementFileKeySpecified { get; set; }

        private string _newAnnouncementFileName;

        [XmlElement(ElementName = "newAnnouncementFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:706")]
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
        public bool NewAnnouncementFileNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _announcementFile;

        [XmlElement(ElementName = "announcementFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:706")]
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
        public bool AnnouncementFileSpecified { get; set; }

    }
}
