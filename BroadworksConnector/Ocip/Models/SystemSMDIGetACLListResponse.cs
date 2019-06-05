using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIGetACLListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _aclTable;

    [XmlElement(ElementName = "aclTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AclTable {
        get => _aclTable;
        set {
            AclTableSpecified = true;
            _aclTable = value;
        }
    }

    [XmlIgnore]
    public bool AclTableSpecified { get; set; }
}
}
