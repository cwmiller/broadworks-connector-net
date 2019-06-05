using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrivacyGetAvailableMonitorsUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _availableMonitorsTable;

    [XmlElement(ElementName = "availableMonitorsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableMonitorsTable {
        get => _availableMonitorsTable;
        set {
            AvailableMonitorsTableSpecified = true;
            _availableMonitorsTable = value;
        }
    }

    [XmlIgnore]
    public bool AvailableMonitorsTableSpecified { get; set; }
}
}
