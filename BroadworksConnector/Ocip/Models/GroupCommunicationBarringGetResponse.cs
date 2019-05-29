using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useDefaultServiceProviderProfile", IsNullable = false)]
    public bool UseDefaultServiceProviderProfile { get; set; }
    [XmlElement(ElementName = "profile", IsNullable = false)]
    public string Profile { get; set; }
 }
}
