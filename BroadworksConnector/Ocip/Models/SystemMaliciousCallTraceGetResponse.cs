using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMaliciousCallTraceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _playMCTWarningAnnouncement;

    [XmlElement(ElementName = "playMCTWarningAnnouncement", IsNullable = false, Namespace = "")]
    public bool PlayMCTWarningAnnouncement {
        get => _playMCTWarningAnnouncement;
        set {
            PlayMCTWarningAnnouncementSpecified = true;
            _playMCTWarningAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool PlayMCTWarningAnnouncementSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _userTable;

    [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable {
        get => _userTable;
        set {
            UserTableSpecified = true;
            _userTable = value;
        }
    }

    [XmlIgnore]
    public bool UserTableSpecified { get; set; }
}
}
