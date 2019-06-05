using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _flexibleSeatingHostTable;

    [XmlElement(ElementName = "flexibleSeatingHostTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable FlexibleSeatingHostTable {
        get => _flexibleSeatingHostTable;
        set {
            FlexibleSeatingHostTableSpecified = true;
            _flexibleSeatingHostTable = value;
        }
    }

    [XmlIgnore]
    public bool FlexibleSeatingHostTableSpecified { get; set; }
}
}
