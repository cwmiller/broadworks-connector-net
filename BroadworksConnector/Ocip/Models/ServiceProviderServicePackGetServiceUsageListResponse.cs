using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackGetServiceUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceUsageTable;

    [XmlElement(ElementName = "serviceUsageTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceUsageTable {
        get => _serviceUsageTable;
        set {
            ServiceUsageTableSpecified = true;
            _serviceUsageTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUsageTableSpecified { get; set; }
}
}
