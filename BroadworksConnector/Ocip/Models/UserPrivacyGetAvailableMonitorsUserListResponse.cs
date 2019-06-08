using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrivacyGetAvailableMonitorsUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _availableMonitorsTable;

    [XmlElement(ElementName = "availableMonitorsTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AvailableMonitorsTable {
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
