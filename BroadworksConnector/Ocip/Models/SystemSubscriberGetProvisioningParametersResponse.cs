using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSubscriberGetProvisioningParametersResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "configurableCLIDNormalization", IsNullable = false)]
    public bool ConfigurableCLIDNormalization { get; set; }
 }
}
