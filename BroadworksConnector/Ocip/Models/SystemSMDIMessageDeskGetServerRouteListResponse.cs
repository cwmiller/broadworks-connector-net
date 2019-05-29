using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIMessageDeskGetServerRouteListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "smdiServerRouteTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SmdiServerRouteTable { get; set; }
 }
}
