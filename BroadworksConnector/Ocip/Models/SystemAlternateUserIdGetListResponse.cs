using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAlternateUserIdGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _alternateUserIdTable;

    [XmlElement(ElementName = "alternateUserIdTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AlternateUserIdTable {
        get => _alternateUserIdTable;
        set {
            AlternateUserIdTableSpecified = true;
            _alternateUserIdTable = value;
        }
    }

    [XmlIgnore]
    public bool AlternateUserIdTableSpecified { get; set; }
}
}
