using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetServiceInstanceListInServiceProviderResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _serviceInstanceTable;

    [XmlElement(ElementName = "serviceInstanceTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ServiceInstanceTable {
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
