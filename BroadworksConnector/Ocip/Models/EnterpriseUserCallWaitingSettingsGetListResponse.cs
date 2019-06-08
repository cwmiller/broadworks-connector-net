using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseUserCallWaitingSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _userCallWaitingTable;

    [XmlElement(ElementName = "userCallWaitingTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserCallWaitingTable {
        get => _userCallWaitingTable;
        set {
            UserCallWaitingTableSpecified = true;
            _userCallWaitingTable = value;
        }
    }

    [XmlIgnore]
    public bool UserCallWaitingTableSpecified { get; set; }
}
}
