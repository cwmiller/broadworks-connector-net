using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupSecurityClassificationCustomizationGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _securityClassificationNameTable;

    [XmlElement(ElementName = "securityClassificationNameTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SecurityClassificationNameTable {
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
