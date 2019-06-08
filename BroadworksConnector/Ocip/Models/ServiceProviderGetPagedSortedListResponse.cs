using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGetPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderTable;

    [XmlElement(ElementName = "serviceProviderTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderTable {
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
