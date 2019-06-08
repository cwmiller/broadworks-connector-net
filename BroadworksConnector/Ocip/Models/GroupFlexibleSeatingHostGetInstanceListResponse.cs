using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _flexibleSeatingHostTable;

    [XmlElement(ElementName = "flexibleSeatingHostTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable FlexibleSeatingHostTable {
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
