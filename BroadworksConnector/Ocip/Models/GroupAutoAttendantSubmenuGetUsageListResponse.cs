using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantSubmenuGetUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _submenuTable;

    [XmlElement(ElementName = "submenuTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SubmenuTable {
        get => _submenuTable;
        set {
            SubmenuTableSpecified = true;
            _submenuTable = value;
        }
    }

    [XmlIgnore]
    public bool SubmenuTableSpecified { get; set; }
}
}
