using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerNetworkClassOfServiceGetAssignedServiceProviderListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _spTable;

    [XmlElement(ElementName = "spTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SpTable {
        get => _spTable;
        set {
            SpTableSpecified = true;
            _spTable = value;
        }
    }

    [XmlIgnore]
    public bool SpTableSpecified { get; set; }
}
}
