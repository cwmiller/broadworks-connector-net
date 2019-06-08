using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderEndpointGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _endpointTable;

    [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable EndpointTable {
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
