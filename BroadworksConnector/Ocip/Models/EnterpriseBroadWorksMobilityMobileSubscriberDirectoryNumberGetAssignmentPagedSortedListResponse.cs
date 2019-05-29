using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersAssignmentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersAssignmentTable { get; set; }
 }
}
