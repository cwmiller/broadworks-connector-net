using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMoveMessage 
{
    [XmlElement(ElementName = "messageCode", IsNullable = false)]
    public int MessageCode { get; set; }
    [XmlElement(ElementName = "summary", IsNullable = false)]
    public string Summary { get; set; }
    [XmlElement(ElementName = "summaryEnglish", IsNullable = false)]
    public string SummaryEnglish { get; set; }
 }
}
