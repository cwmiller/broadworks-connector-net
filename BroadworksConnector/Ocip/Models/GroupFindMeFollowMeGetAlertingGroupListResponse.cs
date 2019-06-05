using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeGetAlertingGroupListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _alertingGroupTable;

    [XmlElement(ElementName = "alertingGroupTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AlertingGroupTable {
        get => _alertingGroupTable;
        set {
            AlertingGroupTableSpecified = true;
            _alertingGroupTable = value;
        }
    }

    [XmlIgnore]
    public bool AlertingGroupTableSpecified { get; set; }
}
}
