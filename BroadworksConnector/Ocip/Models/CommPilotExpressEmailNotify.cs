using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressEmailNotify 
{
    [XmlElement(ElementName = "sendEmail", IsNullable = false)]
    public bool SendEmail { get; set; }
    [XmlElement(ElementName = "emailAddress", IsNullable = false)]
    public string EmailAddress { get; set; }
 }
}
