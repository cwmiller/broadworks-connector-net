using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDialPlanPolicyGetAccessCodeListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _accessCodeTable;

    [XmlElement(ElementName = "accessCodeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AccessCodeTable {
        get => _accessCodeTable;
        set {
            AccessCodeTableSpecified = true;
            _accessCodeTable = value;
        }
    }

    [XmlIgnore]
    public bool AccessCodeTableSpecified { get; set; }
}
}
