using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserAnnouncementFileGetPagedSortedListRequest.
    /// The response contains a table with columns: "Name", "Media Type", and "File Size".
    /// The "Name" column contains the name of the announcement file.
    /// The "Media Type" column contains the media type of the announcement.
    /// File with the possible values:
    /// WMA - Windows Media Audio file
    /// WAV - A WAV file
    /// 3GP - A 3GP file
    /// MOV - A MOV file using a H.263 or H.264 codec.
    /// The "File Size" column contains the file size (KB) of the announcement file.
    /// <see cref="UserAnnouncementFileGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:644""}]")]
    public class UserAnnouncementFileGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _announcementTable;

        [XmlElement(ElementName = "announcementTable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:644")]
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
