using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRouteListEnterpriseTrunkNumberPrefixGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberPrefixTable;

    [XmlElement(ElementName = "availableNumberPrefixTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AvailableNumberPrefixTable {
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
