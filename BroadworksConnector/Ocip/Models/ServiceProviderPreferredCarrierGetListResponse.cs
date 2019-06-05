using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceProviderCarrierTable;

    [XmlElement(ElementName = "serviceProviderCarrierTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderCarrierTable {
        get => _serviceProviderCarrierTable;
        set {
            ServiceProviderCarrierTableSpecified = true;
            _serviceProviderCarrierTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderCarrierTableSpecified { get; set; }
}
}
