using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _huntGroupTable;

    [XmlElement(ElementName = "huntGroupTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable HuntGroupTable {
        get => _huntGroupTable;
        set {
            HuntGroupTableSpecified = true;
            _huntGroupTable = value;
        }
    }

    [XmlIgnore]
    public bool HuntGroupTableSpecified { get; set; }
}
}
