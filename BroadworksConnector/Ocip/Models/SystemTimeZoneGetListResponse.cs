using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTimeZoneGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "timeZoneTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TimeZoneTable { get; set; }
 }
}
