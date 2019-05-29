using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumber", IsNullable = false)]
    public List<string> AvailableMobileSubscriberDirectoryNumber { get; set; }
 }
}
