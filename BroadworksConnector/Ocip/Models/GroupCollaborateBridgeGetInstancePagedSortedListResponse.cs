using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeGetInstancePagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _collaborateBridgeTable;

    [XmlElement(ElementName = "collaborateBridgeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CollaborateBridgeTable {
        get => _collaborateBridgeTable;
        set {
            CollaborateBridgeTableSpecified = true;
            _collaborateBridgeTable = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateBridgeTableSpecified { get; set; }
}
}
