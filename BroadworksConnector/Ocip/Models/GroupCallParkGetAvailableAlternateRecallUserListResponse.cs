using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetAvailableAlternateRecallUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _availableHuntGroupTable;

    [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AvailableHuntGroupTable {
        get => _availableHuntGroupTable;
        set {
            AvailableHuntGroupTableSpecified = true;
            _availableHuntGroupTable = value;
        }
    }

    [XmlIgnore]
    public bool AvailableHuntGroupTableSpecified { get; set; }
}
}
