using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderFileRepositoryDeviceUserAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "fileRepositoryName", IsNullable = false)]
    public string FileRepositoryName { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = false)]
    public string UserName { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
    [XmlElement(ElementName = "allowPut", IsNullable = false)]
    public bool AllowPut { get; set; }
    [XmlElement(ElementName = "allowDelete", IsNullable = false)]
    public bool AllowDelete { get; set; }
    [XmlElement(ElementName = "allowGet", IsNullable = false)]
    public bool AllowGet { get; set; }
 }
}
