using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _availableNumberRangeTable;

    [XmlElement(ElementName = "availableNumberRangeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AvailableNumberRangeTable {
        get => _availableNumberRangeTable;
        set {
            AvailableNumberRangeTableSpecified = true;
            _availableNumberRangeTable = value;
        }
    }

    [XmlIgnore]
    public bool AvailableNumberRangeTableSpecified { get; set; }
}
}
