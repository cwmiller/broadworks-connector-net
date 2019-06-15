using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAnnouncementFileGetAvailableListRequest.
    /// The response contains a table with columns: "Name", "Media Type", "File Size" and "Repository Type".
    /// The "Name" column contains the name of the announcement file.
    /// The "Media Type" column contains the media type of the announcement file with the possible values:
    /// WMA - Windows Media Audio file
    /// WAV - A WAV file
    /// 3GP - A 3GP file
    /// MOV - A MOV file using a H.263 or H.264 codec.
    /// The "File Size" is in Kilobytes.
    /// The "Repository Type" column contains the type of repository for the announcement file such as "User" or "Group"
    /// The "File Size" column contains the file size in kB of the announcement file.
        /// <see cref="UserAnnouncementFileGetAvailableListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserAnnouncementFileGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
    }
}
