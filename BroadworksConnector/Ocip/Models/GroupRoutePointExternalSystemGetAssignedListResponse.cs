using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointExternalSystemGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _externalSystemTable;

    [XmlElement(ElementName = "externalSystemTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ExternalSystemTable {
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
