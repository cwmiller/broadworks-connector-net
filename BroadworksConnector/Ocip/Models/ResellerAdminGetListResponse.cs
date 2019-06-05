using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerAdminGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _resellerAdminTable;

    [XmlElement(ElementName = "resellerAdminTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ResellerAdminTable {
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
