using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceUserGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "allowPut", IsNullable = false)]
    public bool AllowPut { get; set; }
    [XmlElement(ElementName = "allowDelete", IsNullable = false)]
    public bool AllowDelete { get; set; }
    [XmlElement(ElementName = "allowGet", IsNullable = false)]
    public bool AllowGet { get; set; }
 }
}
