using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDnGetActivationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

    [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DnTable {
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
