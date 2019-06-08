using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _groupsUsingCarrierTable;

    [XmlElement(ElementName = "groupsUsingCarrierTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable GroupsUsingCarrierTable {
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
