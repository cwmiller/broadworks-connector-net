using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallingPartyCategoryGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "category", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingPartyCategorySelection Category { get; set; }
 }
}
