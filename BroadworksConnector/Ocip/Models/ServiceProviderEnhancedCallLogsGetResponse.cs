using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderEnhancedCallLogsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxLoggedCalls", IsNullable = false)]
    public int MaxLoggedCalls { get; set; }
    [XmlElement(ElementName = "callExpirationDays", IsNullable = false)]
    public int CallExpirationDays { get; set; }
 }
}
