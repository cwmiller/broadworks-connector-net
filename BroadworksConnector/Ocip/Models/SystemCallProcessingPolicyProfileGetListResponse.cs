using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _callProcessingPolicyProfilesTable;

    [XmlElement(ElementName = "callProcessingPolicyProfilesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CallProcessingPolicyProfilesTable {
        get => _callProcessingPolicyProfilesTable;
        set {
            CallProcessingPolicyProfilesTableSpecified = true;
            _callProcessingPolicyProfilesTable = value;
        }
    }

    [XmlIgnore]
    public bool CallProcessingPolicyProfilesTableSpecified { get; set; }
}
}
