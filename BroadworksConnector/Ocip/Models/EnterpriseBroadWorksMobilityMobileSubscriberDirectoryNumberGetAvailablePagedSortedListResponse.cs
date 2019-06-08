using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _availableMobileSubscriberDirectoryNumberTable;

    [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AvailableMobileSubscriberDirectoryNumberTable {
        get => _availableMobileSubscriberDirectoryNumberTable;
        set {
            AvailableMobileSubscriberDirectoryNumberTableSpecified = true;
            _availableMobileSubscriberDirectoryNumberTable = value;
        }
    }

    [XmlIgnore]
    public bool AvailableMobileSubscriberDirectoryNumberTableSpecified { get; set; }
}
}
