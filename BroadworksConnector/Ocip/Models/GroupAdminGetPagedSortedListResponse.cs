using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdminGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _groupAdminTable;

    [XmlElement(ElementName = "groupAdminTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable GroupAdminTable {
        get => _groupAdminTable;
        set {
            GroupAdminTableSpecified = true;
            _groupAdminTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupAdminTableSpecified { get; set; }
}
}
