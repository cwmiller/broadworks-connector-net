using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetListResponse14 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderAdminTable;

    [XmlElement(ElementName = "serviceProviderAdminTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderAdminTable {
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
