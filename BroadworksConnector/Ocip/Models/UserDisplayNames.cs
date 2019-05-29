using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDisplayNames 
{
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "hiraganaLastName", IsNullable = false)]
    public string HiraganaLastName { get; set; }
    [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false)]
    public string HiraganaFirstName { get; set; }
 }
}
