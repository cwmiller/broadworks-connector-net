using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumberTable;

    [XmlElement(ElementName = "mobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumberTable {
        get => _mobileSubscriberDirectoryNumberTable;
        set {
            MobileSubscriberDirectoryNumberTableSpecified = true;
            _mobileSubscriberDirectoryNumberTable = value;
        }
    }

    [XmlIgnore]
    public bool MobileSubscriberDirectoryNumberTableSpecified { get; set; }
}
}
