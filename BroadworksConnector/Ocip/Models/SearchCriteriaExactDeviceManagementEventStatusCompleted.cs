using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventStatusCompleted : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "dmEventStatusCompleted", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventStatusCompleted DmEventStatusCompleted { get; set; }
 }
}
