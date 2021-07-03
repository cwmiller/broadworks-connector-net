using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAnnouncementFileGetAvailableListRequest.
    /// The response contains a table with columns: "Name", "Media Type", "File Size", "Repository Type", and "Announcement File External Id".
    /// The "Name" column contains the name of the announcement file.
    /// The "Media Type" column contains the media type of the announcement file with the possible values:
    /// WMA - Windows Media Audio file
    /// WAV - A WAV file
    /// 3GP - A 3GP file
    /// MOV - A MOV file using a H.263 or H.264 codec.
    /// The "File Size" is in Kilobytes.
    /// The "Repository Type" column contains the type of repository for the announcement file such as "User" or "Group"
    /// The "File Size" column contains the file size in kB of the announcement file.
    /// The "Announcement File External Id" column contains the External Id of the announcement file.
    /// 
    /// The following columns are populated in AS data mode only:
    /// "Announcement File External Id"
    /// <see cref="UserAnnouncementFileGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:578""}]")]
    public class UserAnnouncementFileGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _announcementTable;

        [XmlElement(ElementName = "announcementTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:578")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AnnouncementTable
        {
            get => _announcementTable;
            set
            {
                AnnouncementTableSpecified = true;
                _announcementTable = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementTableSpecified { get; set; }

    }
}
