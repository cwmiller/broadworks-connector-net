using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExpensiveCallTypeGetListResponse16sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "alternateCallIndicatorTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AlternateCallIndicatorTable { get; set; }
 }
}
