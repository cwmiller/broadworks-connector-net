using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _unreachableFromPrimaryUserTable;

    [XmlElement(ElementName = "unreachableFromPrimaryUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UnreachableFromPrimaryUserTable {
        get => _unreachableFromPrimaryUserTable;
        set {
            UnreachableFromPrimaryUserTableSpecified = true;
            _unreachableFromPrimaryUserTable = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableFromPrimaryUserTableSpecified { get; set; }
}
}
