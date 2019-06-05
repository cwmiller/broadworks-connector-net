using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetGroupListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _groupsUsingCarrierTable;

    [XmlElement(ElementName = "groupsUsingCarrierTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupsUsingCarrierTable {
        get => _groupsUsingCarrierTable;
        set {
            GroupsUsingCarrierTableSpecified = true;
            _groupsUsingCarrierTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupsUsingCarrierTableSpecified { get; set; }
}
}
