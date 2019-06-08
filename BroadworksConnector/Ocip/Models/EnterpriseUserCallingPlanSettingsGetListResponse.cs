using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseUserCallingPlanSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _userCallingPlanTable;

    [XmlElement(ElementName = "userCallingPlanTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserCallingPlanTable {
        get => _userCallingPlanTable;
        set {
            UserCallingPlanTableSpecified = true;
            _userCallingPlanTable = value;
        }
    }

    [XmlIgnore]
    public bool UserCallingPlanTableSpecified { get; set; }
}
}
