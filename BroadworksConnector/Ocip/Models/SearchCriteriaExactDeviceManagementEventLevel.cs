using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "dmEventLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventLevel DmEventLevel { get; set; }
 }
}
