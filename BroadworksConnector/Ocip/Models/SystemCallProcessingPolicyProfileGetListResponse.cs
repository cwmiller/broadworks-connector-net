using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _callProcessingPolicyProfilesTable;

    [XmlElement(ElementName = "callProcessingPolicyProfilesTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CallProcessingPolicyProfilesTable {
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
