using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _findMeFollowMeTable;

    [XmlElement(ElementName = "findMeFollowMeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable FindMeFollowMeTable {
        get => _findMeFollowMeTable;
        set {
            FindMeFollowMeTableSpecified = true;
            _findMeFollowMeTable = value;
        }
    }

    [XmlIgnore]
    public bool FindMeFollowMeTableSpecified { get; set; }
}
}
