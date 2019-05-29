using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersSummaryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersSummaryTable { get; set; }
 }
}
