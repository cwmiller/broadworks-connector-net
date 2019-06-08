using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersAssignmentTable;

    [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersAssignmentTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersAssignmentTable {
        get => _mobileSubscriberDirectoryNumbersAssignmentTable;
        set {
            MobileSubscriberDirectoryNumbersAssignmentTableSpecified = true;
            _mobileSubscriberDirectoryNumbersAssignmentTable = value;
        }
    }

    [XmlIgnore]
    public bool MobileSubscriberDirectoryNumbersAssignmentTableSpecified { get; set; }
}
}
