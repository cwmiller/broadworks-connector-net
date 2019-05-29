using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityGetIMRNListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaIMRN> SearchCriteriaIMRN { get; set; }
 }
}
