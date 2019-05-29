using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "fileRepositoryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable FileRepositoryTable { get; set; }
 }
}
