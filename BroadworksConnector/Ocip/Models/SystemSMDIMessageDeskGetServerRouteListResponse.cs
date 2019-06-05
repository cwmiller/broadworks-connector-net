using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskGetServerRouteListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _smdiServerRouteTable;

    [XmlElement(ElementName = "smdiServerRouteTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SmdiServerRouteTable {
        get => _smdiServerRouteTable;
        set {
            SmdiServerRouteTableSpecified = true;
            _smdiServerRouteTable = value;
        }
    }

    [XmlIgnore]
    public bool SmdiServerRouteTableSpecified { get; set; }
}
}
