using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetEnhancedConfigurationTypeResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "supportsEnhancedConfiguration", IsNullable = false)]
    public bool SupportsEnhancedConfiguration { get; set; }
    [XmlElement(ElementName = "supportsReset", IsNullable = false)]
    public bool SupportsReset { get; set; }
    [XmlElement(ElementName = "configurationType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigurationType { get; set; }
    [XmlElement(ElementName = "configurationFileName", IsNullable = false)]
    public string ConfigurationFileName { get; set; }
 }
}
