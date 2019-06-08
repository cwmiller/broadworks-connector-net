using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobileManagerGetHomeZoneListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _homeZonesTable;

    [XmlElement(ElementName = "homeZonesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable HomeZonesTable {
        get => _homeZonesTable;
        set {
            HomeZonesTableSpecified = true;
            _homeZonesTable = value;
        }
    }

    [XmlIgnore]
    public bool HomeZonesTableSpecified { get; set; }
}
}
