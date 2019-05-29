using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSMDIMessageDeskGetServerListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "smdiServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SmdiServerTable { get; set; }
 }
}
