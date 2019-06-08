using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksAnywhereGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _broadWorksAnywhereTable;

    [XmlElement(ElementName = "broadWorksAnywhereTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable BroadWorksAnywhereTable {
        get => _broadWorksAnywhereTable;
        set {
            BroadWorksAnywhereTableSpecified = true;
            _broadWorksAnywhereTable = value;
        }
    }

    [XmlIgnore]
    public bool BroadWorksAnywhereTableSpecified { get; set; }
}
}
