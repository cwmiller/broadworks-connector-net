using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateRoomListGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _roomInstanceTable;

    [XmlElement(ElementName = "roomInstanceTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RoomInstanceTable {
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
