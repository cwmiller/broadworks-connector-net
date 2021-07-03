using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAnnouncementFileGetPagedSortedListRequest.
    /// The response contains a table with columns: "Name", "Media Type", "File Size", and "Announcement File External Id".
    /// The "Name" column contains the name of the announcement file.
    /// The "Media Type" column contains the media type of the announcement
    /// File with the possible values:
    /// WMA - Windows Media Audio file
    /// WAV - A WAV file
    /// 3GP - A 3GP file
    /// MOV - A MOV file using a H.263 or H.264 codec.
    /// The "File Size" column contains the file size (KB) of the announcement file.
    /// 
    /// The following columns are populated in AS data mode only:
    /// "Announcement File External Id"
    /// <see cref="GroupAnnouncementFileGetPagedSortedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1999""}]")]
    public class GroupAnnouncementFileGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _announcementTable;

        [XmlElement(ElementName = "announcementTable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1999")]
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
