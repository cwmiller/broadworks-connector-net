using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mobileSubscriberDirectoryNumber", IsNullable = false)]
    public List<string> MobileSubscriberDirectoryNumber { get; set; }
 }
}
