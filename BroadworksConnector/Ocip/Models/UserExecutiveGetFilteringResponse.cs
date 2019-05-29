using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveGetFilteringResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableFiltering", IsNullable = false)]
    public bool EnableFiltering { get; set; }
    [XmlElement(ElementName = "filteringMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringMode FilteringMode { get; set; }
    [XmlElement(ElementName = "simpleFilterType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveCallFilteringSimpleFilterType SimpleFilterType { get; set; }
    [XmlElement(ElementName = "criteriaTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable { get; set; }
 }
}
