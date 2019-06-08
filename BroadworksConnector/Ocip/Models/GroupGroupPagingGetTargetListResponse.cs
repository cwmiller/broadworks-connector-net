using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetTargetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _targetTable;

    [XmlElement(ElementName = "targetTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TargetTable {
        get => _targetTable;
        set {
            TargetTableSpecified = true;
            _targetTable = value;
        }
    }

    [XmlIgnore]
    public bool TargetTableSpecified { get; set; }
}
}
