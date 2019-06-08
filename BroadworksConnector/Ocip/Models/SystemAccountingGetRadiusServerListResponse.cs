using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingGetRadiusServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _radiusServerTable;

    [XmlElement(ElementName = "radiusServerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable RadiusServerTable {
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
