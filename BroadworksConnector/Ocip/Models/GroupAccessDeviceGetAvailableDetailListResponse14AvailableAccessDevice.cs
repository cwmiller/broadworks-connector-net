using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice 
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false)]
    public bool StaticRegistrationCapable { get; set; }
    [XmlElement(ElementName = "useDomain", IsNullable = false)]
    public bool UseDomain { get; set; }
 }
}
