using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSResourcePriorityGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _resourcePriorityTable;

    [XmlElement(ElementName = "resourcePriorityTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ResourcePriorityTable {
        get => _resourcePriorityTable;
        set {
            ResourcePriorityTableSpecified = true;
            _resourcePriorityTable = value;
        }
    }

    [XmlIgnore]
    public bool ResourcePriorityTableSpecified { get; set; }
}
}
