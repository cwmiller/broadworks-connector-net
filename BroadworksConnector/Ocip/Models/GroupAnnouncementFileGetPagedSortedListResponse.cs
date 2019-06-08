using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementFileGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
