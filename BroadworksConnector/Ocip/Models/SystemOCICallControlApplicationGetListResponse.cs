using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCICallControlApplicationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "appTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AppTable { get; set; }
 }
}
