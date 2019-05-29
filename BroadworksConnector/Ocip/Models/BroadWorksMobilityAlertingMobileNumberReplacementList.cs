using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class BroadWorksMobilityAlertingMobileNumberReplacementList 
{
    [XmlElement(ElementName = "mobileNumber", IsNullable = false)]
    public List<string> MobileNumber { get; set; }
 }
}
