using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileNetworkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _mobileNetworkTable;

    [XmlElement(ElementName = "mobileNetworkTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable MobileNetworkTable {
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