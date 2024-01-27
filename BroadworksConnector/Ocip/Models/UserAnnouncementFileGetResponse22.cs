using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAnnouncementFileGetRequest22.
    /// The response contains the file size (KB), uploaded timestamp, description and usage for
    /// an announcement file in the user announcement repository.
    /// The usage table has columns "Service Name", "Criteria Name"
    /// The "Service Name"" values correspond to string values of the UserService data types.
    /// With the exception of the string "Voice Portal" which is returned when the announcement is being used by Voice Portal Personalized Name.
    /// For Call Center and Route Point users the "Instance Name" column contains the instance id and
    /// when the announcement is being used by a DNIS, "Intance Name" column contans the instance id and the DNIS id.
    /// For Auto Attendants with submenus and the announcement is used by a submenu the "Instance Name" column will contain the submenu name
    /// 
    /// The following data elements are only used in AS data mode:
    /// announcementFileExternalId
    /// <see cref="UserAnnouncementFileGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:734""}]")]
    public class UserAnnouncementFileGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:734")]
        [MinLength(1)]
        [MaxLength(256)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected int _filesize;

        [XmlElement(ElementName = "filesize", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:734")]
        public int Filesize
        {
            get => _filesize;
            set
            {
                FilesizeSpecified = true;
                _filesize = value;
            }
        }

        [XmlIgnore]
        protected bool FilesizeSpecified { get; set; }

        protected string _lastUploaded;

        [XmlElement(ElementName = "lastUploaded", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:734")]
        public string LastUploaded
        {
            get => _lastUploaded;
            set
            {
                LastUploadedSpecified = true;
                _lastUploaded = value;
            }
        }

        [XmlIgnore]
        protected bool LastUploadedSpecified { get; set; }

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:734")]
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
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:734")]
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
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:734")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:734")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UsageTable
        {
            get => _usageTable;
            set
            {
                UsageTableSpecified = true;
                _usageTable = value;
            }
        }

        [XmlIgnore]
        protected bool UsageTableSpecified { get; set; }

    }
}
