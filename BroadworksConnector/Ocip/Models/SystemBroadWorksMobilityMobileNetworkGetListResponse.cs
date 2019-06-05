using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileNetworkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _mobileNetworkTable;

    [XmlElement(ElementName = "mobileNetworkTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable MobileNetworkTable {
        get => _mobileNetworkTable;
        set {
            MobileNetworkTableSpecified = true;
            _mobileNetworkTable = value;
        }
    }

    [XmlIgnore]
    public bool MobileNetworkTableSpecified { get; set; }
}
}
