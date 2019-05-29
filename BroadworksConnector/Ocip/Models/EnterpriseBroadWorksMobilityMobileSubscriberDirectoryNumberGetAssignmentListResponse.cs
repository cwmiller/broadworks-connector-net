using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAssignmentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mobileSubscriberDirectoryNumbersAssignmentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MobileSubscriberDirectoryNumbersAssignmentTable { get; set; }
 }
}
