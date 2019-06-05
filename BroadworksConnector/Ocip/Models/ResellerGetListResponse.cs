using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _resellerTable;

    [XmlElement(ElementName = "resellerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ResellerTable {
        get => _resellerTable;
        set {
            ResellerTableSpecified = true;
            _resellerTable = value;
        }
    }

    [XmlIgnore]
    public bool ResellerTableSpecified { get; set; }
}
}
