using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupUserCallForwardingSettingsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _userCallForwardingTable;

    [XmlElement(ElementName = "userCallForwardingTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserCallForwardingTable {
        get => _userCallForwardingTable;
        set {
            UserCallForwardingTableSpecified = true;
            _userCallForwardingTable = value;
        }
    }

    [XmlIgnore]
    public bool UserCallForwardingTableSpecified { get; set; }
}
}
