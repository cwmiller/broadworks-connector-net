using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _huntGroupTable;

    [XmlElement(ElementName = "huntGroupTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable HuntGroupTable {
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
