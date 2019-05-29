using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "dmEventStatusInProgressOrPending", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementEventStatusInProgressOrPending DmEventStatusInProgressOrPending { get; set; }
 }
}
