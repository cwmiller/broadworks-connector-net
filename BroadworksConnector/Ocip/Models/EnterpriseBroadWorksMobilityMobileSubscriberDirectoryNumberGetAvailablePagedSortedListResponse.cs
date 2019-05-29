using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumberTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AvailableMobileSubscriberDirectoryNumberTable { get; set; }
 }
}
