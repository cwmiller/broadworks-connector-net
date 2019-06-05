using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetTargetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _targetTable;

    [XmlElement(ElementName = "targetTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TargetTable {
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
