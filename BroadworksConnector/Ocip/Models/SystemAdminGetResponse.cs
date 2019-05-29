using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdminGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "adminType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemAdminType AdminType { get; set; }
    [XmlElement(ElementName = "readOnly", IsNullable = false)]
    public bool ReadOnly { get; set; }
 }
}
