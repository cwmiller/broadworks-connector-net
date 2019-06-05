using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceProviderTable;

    [XmlElement(ElementName = "serviceProviderTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderTable {
        get => _serviceProviderTable;
        set {
            ServiceProviderTableSpecified = true;
            _serviceProviderTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderTableSpecified { get; set; }
}
}
