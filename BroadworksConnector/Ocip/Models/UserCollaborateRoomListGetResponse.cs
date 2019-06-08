using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateRoomListGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _roomInstanceTable;

    [XmlElement(ElementName = "roomInstanceTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RoomInstanceTable {
        get => _roomInstanceTable;
        set {
            RoomInstanceTableSpecified = true;
            _roomInstanceTable = value;
        }
    }

    [XmlIgnore]
    public bool RoomInstanceTableSpecified { get; set; }
}
}
