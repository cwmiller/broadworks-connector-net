using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalPhoneListGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "entry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.PhoneListEntry> Entry { get; set; }
 }
}
