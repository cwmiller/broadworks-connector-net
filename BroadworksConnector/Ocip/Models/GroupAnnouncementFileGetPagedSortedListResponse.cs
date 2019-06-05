using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAnnouncementFileGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.C.OCITable _announcementTable;

        [XmlElement(ElementName = "announcementTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable AnnouncementTable
        {
            get => _announcementTable;
            set
            {
                AnnouncementTableSpecified = true;
                _announcementTable = value;
            }
        }

        [XmlIgnore]
        public bool AnnouncementTableSpecified { get; set; }
    }
}
