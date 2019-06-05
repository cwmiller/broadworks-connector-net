using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _mobileSubscriberDirectoryNumbersSummaryTable;

    [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersSummaryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersSummaryTable {
        get => _mobileSubscriberDirectoryNumbersSummaryTable;
        set {
            MobileSubscriberDirectoryNumbersSummaryTableSpecified = true;
            _mobileSubscriberDirectoryNumbersSummaryTable = value;
        }
    }

    [XmlIgnore]
    public bool MobileSubscriberDirectoryNumbersSummaryTableSpecified { get; set; }
}
}
