using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetListResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceProviderAdminTable;

    [XmlElement(ElementName = "serviceProviderAdminTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderAdminTable {
        get => _serviceProviderAdminTable;
        set {
            ServiceProviderAdminTableSpecified = true;
            _serviceProviderAdminTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderAdminTableSpecified { get; set; }
}
}
