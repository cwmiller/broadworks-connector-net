using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeCustomTagGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceProviderDeviceTypeCustomTagsTable;

    [XmlElement(ElementName = "serviceProviderDeviceTypeCustomTagsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeCustomTagsTable {
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
