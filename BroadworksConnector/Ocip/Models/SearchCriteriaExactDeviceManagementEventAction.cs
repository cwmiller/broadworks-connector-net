using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventAction : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "dmEventAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventAction DmEventAction { get; set; }
 }
}
