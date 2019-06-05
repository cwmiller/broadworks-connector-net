using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderRouteListEnterpriseTrunkNumberRangeGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _availableNumberRangeTable;

    [XmlElement(ElementName = "availableNumberRangeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableNumberRangeTable {
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
