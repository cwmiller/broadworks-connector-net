using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupUserCallForwardingSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _userCallForwardingTable;

    [XmlElement(ElementName = "userCallForwardingTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserCallForwardingTable {
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
