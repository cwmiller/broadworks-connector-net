using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingPartyCategoryGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "callingPartyCategoryTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallingPartyCategoryTable { get; set; }
 }
}
