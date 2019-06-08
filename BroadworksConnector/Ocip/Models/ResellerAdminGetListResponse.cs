using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _resellerAdminTable;

    [XmlElement(ElementName = "resellerAdminTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ResellerAdminTable {
        get => _resellerAdminTable;
        set {
            ResellerAdminTableSpecified = true;
            _resellerAdminTable = value;
        }
    }

    [XmlIgnore]
    public bool ResellerAdminTableSpecified { get; set; }
}
}
