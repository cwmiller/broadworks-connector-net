using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SpeedDial8Entry 
{
    [XmlElement(ElementName = "speedCode", IsNullable = false)]
    public int SpeedCode { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
 }
}
