using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAlternateUserIdGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _alternateUserIdTable;

    [XmlElement(ElementName = "alternateUserIdTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AlternateUserIdTable {
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
