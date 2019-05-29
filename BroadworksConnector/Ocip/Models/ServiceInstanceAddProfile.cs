using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceInstanceAddProfile 
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "callingLineIdLastName", IsNullable = false)]
    public string CallingLineIdLastName { get; set; }
    [XmlElement(ElementName = "callingLineIdFirstName", IsNullable = false)]
    public string CallingLineIdFirstName { get; set; }
    [XmlElement(ElementName = "hiraganaLastName", IsNullable = false)]
    public string HiraganaLastName { get; set; }
    [XmlElement(ElementName = "hiraganaFirstName", IsNullable = false)]
    public string HiraganaFirstName { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "extension", IsNullable = false)]
    public string Extension { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
    [XmlElement(ElementName = "department", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey Department { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "alias", IsNullable = false)]
    public List<string> Alias { get; set; }
    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false)]
    public string PublicUserIdentity { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false)]
    public string CallingLineIdPhoneNumber { get; set; }
 }
}
