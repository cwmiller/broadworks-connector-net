using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class BroadWorksMobilityUserMobileIdentityModifyEntry 
{
    [XmlElement(ElementName = "mobileNumber", IsNullable = false)]
    public string MobileNumber { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "isPrimary", IsNullable = false)]
    public bool IsPrimary { get; set; }
    [XmlElement(ElementName = "enableAlerting", IsNullable = false)]
    public bool EnableAlerting { get; set; }
 }
}
