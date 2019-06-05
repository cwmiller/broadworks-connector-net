using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDnGetActivationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _dnTable;

    [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DnTable {
        get => _dnTable;
        set {
            DnTableSpecified = true;
            _dnTable = value;
        }
    }

    [XmlIgnore]
    public bool DnTableSpecified { get; set; }
}
}
