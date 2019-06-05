using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _availableNumberPrefixTable;

    [XmlElement(ElementName = "availableNumberPrefixTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableNumberPrefixTable {
        get => _availableNumberPrefixTable;
        set {
            AvailableNumberPrefixTableSpecified = true;
            _availableNumberPrefixTable = value;
        }
    }

    [XmlIgnore]
    public bool AvailableNumberPrefixTableSpecified { get; set; }
}
}
