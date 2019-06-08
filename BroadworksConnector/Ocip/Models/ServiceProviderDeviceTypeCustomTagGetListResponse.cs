using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeCustomTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderDeviceTypeCustomTagsTable;

    [XmlElement(ElementName = "serviceProviderDeviceTypeCustomTagsTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeCustomTagsTable {
        get => _serviceProviderDeviceTypeCustomTagsTable;
        set {
            ServiceProviderDeviceTypeCustomTagsTableSpecified = true;
            _serviceProviderDeviceTypeCustomTagsTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderDeviceTypeCustomTagsTableSpecified { get; set; }
}
}
