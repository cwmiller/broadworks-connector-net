using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupSecurityClassificationCustomizationGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _securityClassificationNameTable;

    [XmlElement(ElementName = "securityClassificationNameTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SecurityClassificationNameTable {
        get => _securityClassificationNameTable;
        set {
            SecurityClassificationNameTableSpecified = true;
            _securityClassificationNameTable = value;
        }
    }

    [XmlIgnore]
    public bool SecurityClassificationNameTableSpecified { get; set; }
}
}
