using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "dmEventType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventType DmEventType { get; set; }
 }
}
