using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetServiceInstanceListInServiceProviderResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceInstanceTable;

    [XmlElement(ElementName = "serviceInstanceTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceInstanceTable {
        get => _serviceInstanceTable;
        set {
            ServiceInstanceTableSpecified = true;
            _serviceInstanceTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceTableSpecified { get; set; }
}
}
