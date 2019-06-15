using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAnnouncementFileGetListRequest.
    /// When requested, the response contains a table with columns: "Name", "Media Type", "File Size".
    /// The "Name" column contains the name of the announcement file.
    /// The "Media Type" column contains the media type of the announcement file with the possible values:
    /// WMA - Windows Media Audio file
    /// WAV - A WAV file
    /// 3GP - A 3GP file
    /// MOV - A MOV file using a H.263 or H.264 codec.
    /// The "File Size" column contains the file size in kB of the announcement file.
    /// The response also contains the current total file size (KB) for the user across
    /// all media types and the maximum total file size (MB) allowed for the user.
        /// <see cref="UserAnnouncementFileGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserAnnouncementFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _announcementTable;

        [XmlElement(ElementName = "announcementTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AnnouncementTable {
            get => _announcementTable;
            set {
                AnnouncementTableSpecified = true;
                _announcementTable = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementTableSpecified { get; set; }
        
        private int _totalFileSize;

        [XmlElement(ElementName = "totalFileSize", IsNullable = false, Namespace = "")]
        public int TotalFileSize {
            get => _totalFileSize;
            set {
                TotalFileSizeSpecified = true;
                _totalFileSize = value;
            }
        }

        [XmlIgnore]
        public bool TotalFileSizeSpecified { get; set; }
        
        private int _maxFileSize;

        [XmlElement(ElementName = "maxFileSize", IsNullable = false, Namespace = "")]
        public int MaxFileSize {
            get => _maxFileSize;
            set {
                MaxFileSizeSpecified = true;
                _maxFileSize = value;
            }
        }

        [XmlIgnore]
        public bool MaxFileSizeSpecified { get; set; }
        
    }
}
