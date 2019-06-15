using System;
using System.Xml.Serialization;
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
     
    public class UserAnnouncementFileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private int _filesize;

        [XmlElement(ElementName = "filesize", IsNullable = false, Namespace = "")]
        public int Filesize {
            get => _filesize;
            set {
                FilesizeSpecified = true;
                _filesize = value;
            }
        }

        [XmlIgnore]
        public bool FilesizeSpecified { get; set; }
        
        private string _lastUploaded;

        [XmlElement(ElementName = "lastUploaded", IsNullable = false, Namespace = "")]
        public string LastUploaded {
            get => _lastUploaded;
            set {
                LastUploadedSpecified = true;
                _lastUploaded = value;
            }
        }

        [XmlIgnore]
        public bool LastUploadedSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UsageTable {
            get => _usageTable;
            set {
                UsageTableSpecified = true;
                _usageTable = value;
            }
        }

        [XmlIgnore]
        public bool UsageTableSpecified { get; set; }
        
    }
}
