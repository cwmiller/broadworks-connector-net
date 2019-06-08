using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantGetInstancePagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _autoAttendantTable;

    [XmlElement(ElementName = "autoAttendantTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AutoAttendantTable {
        get => _autoAttendantTable;
        set {
            AutoAttendantTableSpecified = true;
            _autoAttendantTable = value;
        }
    }

    [XmlIgnore]
    public bool AutoAttendantTableSpecified { get; set; }
}
}
