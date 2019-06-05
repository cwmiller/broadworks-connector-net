using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPushNotificationAllowedApplicationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _applicationTable;

    [XmlElement(ElementName = "applicationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ApplicationTable {
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
