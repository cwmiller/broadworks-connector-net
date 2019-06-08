using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _unreachableFromPrimaryUserTable;

    [XmlElement(ElementName = "unreachableFromPrimaryUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UnreachableFromPrimaryUserTable {
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
