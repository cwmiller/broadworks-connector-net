using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEndpointGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _endpointTable;

    [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable EndpointTable {
        get => _endpointTable;
        set {
            EndpointTableSpecified = true;
            _endpointTable = value;
        }
    }

    [XmlIgnore]
    public bool EndpointTableSpecified { get; set; }
}
}
