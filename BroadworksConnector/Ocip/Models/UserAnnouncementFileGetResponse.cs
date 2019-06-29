using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAnnouncementFileGetRequest.
    /// The response contains the file size (KB), uploaded timestamp, description and usage for
    /// an announcement file in the user announcement repository.
    /// The usage table has columns "Service Name", "Criteria Name"
    /// The "Service Name"" values correspond to string values of the UserService data types.
    /// With the exception of the string "Voice Portal" which is returned when the announcement is being used by Voice Portal Personalized Name.
    /// For Call Center and Route Point users the "Instance Name" column contains the instance id and
    /// when the announcement is being used by a DNIS, "Intance Name" column contans the instance id and the DNIS id.
    /// For Auto Attendants with submenus and the announcement is used by a submenu the "Instance Name" column will contain the submenu name
    /// <see cref="UserAnnouncementFileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:684""}]")]
    public class UserAnnouncementFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:684")]
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

        private int _filesize;

        [XmlElement(ElementName = "filesize", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:684")]
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

        private string _lastUploaded;

        [XmlElement(ElementName = "lastUploaded", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:684")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:684")]
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
