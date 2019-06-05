using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingGetRadiusServerListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _radiusServerTable;

    [XmlElement(ElementName = "radiusServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable RadiusServerTable {
        get => _radiusServerTable;
        set {
            RadiusServerTableSpecified = true;
            _radiusServerTable = value;
        }
    }

    [XmlIgnore]
    public bool RadiusServerTableSpecified { get; set; }
}
}
