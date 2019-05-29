using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSAvpCodeMapGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "avpCodeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AvpCodeTable { get; set; }
 }
}
