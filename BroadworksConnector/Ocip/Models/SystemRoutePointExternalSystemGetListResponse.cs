using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutePointExternalSystemGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _externalSystemTable;

    [XmlElement(ElementName = "externalSystemTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ExternalSystemTable {
        get => _externalSystemTable;
        set {
            ExternalSystemTableSpecified = true;
            _externalSystemTable = value;
        }
    }

    [XmlIgnore]
    public bool ExternalSystemTableSpecified { get; set; }
}
}
