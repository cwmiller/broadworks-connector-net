using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _collaborateBridgeTable;

    [XmlElement(ElementName = "collaborateBridgeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CollaborateBridgeTable {
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
