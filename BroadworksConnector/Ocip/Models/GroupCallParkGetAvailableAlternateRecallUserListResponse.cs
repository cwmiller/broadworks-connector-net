using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetAvailableAlternateRecallUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _availableHuntGroupTable;

    [XmlElement(ElementName = "availableHuntGroupTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableHuntGroupTable {
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
