using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceFileGetResponse16sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "fileSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode FileSource { get; set; }
    [XmlElement(ElementName = "configurationFileName", IsNullable = false)]
    public string ConfigurationFileName { get; set; }
    [XmlElement(ElementName = "accessUrl", IsNullable = false)]
    public string AccessUrl { get; set; }
    [XmlElement(ElementName = "repositoryUrl", IsNullable = false)]
    public string RepositoryUrl { get; set; }
    [XmlElement(ElementName = "templateUrl", IsNullable = false)]
    public string TemplateUrl { get; set; }
 }
}
