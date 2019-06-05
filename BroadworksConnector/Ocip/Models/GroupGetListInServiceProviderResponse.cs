using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetListInServiceProviderResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _groupTable;

    [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupTable {
        get => _groupTable;
        set {
            GroupTableSpecified = true;
            _groupTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupTableSpecified { get; set; }
}
}
