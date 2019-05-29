using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactMediaFileType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType Type { get; set; }
 }
}
