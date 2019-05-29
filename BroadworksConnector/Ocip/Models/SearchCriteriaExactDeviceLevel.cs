using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactDeviceLevel : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "deviceLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel { get; set; }
 }
}
