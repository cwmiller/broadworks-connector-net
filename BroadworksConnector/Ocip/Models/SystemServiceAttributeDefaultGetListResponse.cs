using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ServiceAttributeEntryRead> ServiceAttributeEntry { get; set; }
 }
}
