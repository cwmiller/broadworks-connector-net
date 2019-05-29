using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPGetContentTypeListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "contentTypeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ContentTypeTable { get; set; }
 }
}
