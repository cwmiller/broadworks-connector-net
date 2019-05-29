using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PrimaryInfoGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "isPrivate", IsNullable = false)]
    public bool IsPrivate { get; set; }
    [XmlElement(ElementName = "isAddressInfoRequested", IsNullable = false)]
    public bool IsAddressInfoRequested { get; set; }
 }
}
