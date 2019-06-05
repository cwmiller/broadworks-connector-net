using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSMDIMessageDeskGetServerListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _smdiServerTable;

    [XmlElement(ElementName = "smdiServerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SmdiServerTable {
        get => _smdiServerTable;
        set {
            SmdiServerTableSpecified = true;
            _smdiServerTable = value;
        }
    }

    [XmlIgnore]
    public bool SmdiServerTableSpecified { get; set; }
}
}
