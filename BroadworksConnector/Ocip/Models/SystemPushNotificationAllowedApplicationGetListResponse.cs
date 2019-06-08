using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPushNotificationAllowedApplicationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _applicationTable;

    [XmlElement(ElementName = "applicationTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ApplicationTable {
        get => _applicationTable;
        set {
            ApplicationTableSpecified = true;
            _applicationTable = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationTableSpecified { get; set; }
}
}
