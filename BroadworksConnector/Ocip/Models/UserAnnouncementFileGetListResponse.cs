using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
