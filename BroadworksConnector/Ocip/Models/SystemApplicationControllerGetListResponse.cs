using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemApplicationControllerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "applicationControllerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ApplicationControllerTable { get; set; }
 }
}
