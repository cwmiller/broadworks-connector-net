using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterAgentThresholdProfileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _profilesTable;

    [XmlElement(ElementName = "profilesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ProfilesTable {
        get => _profilesTable;
        set {
            ProfilesTableSpecified = true;
            _profilesTable = value;
        }
    }

    [XmlIgnore]
    public bool ProfilesTableSpecified { get; set; }
}
}
