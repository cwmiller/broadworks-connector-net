using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSubscriberGetLoginParametersResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false)]
    public int MaxFailedLoginAttempts { get; set; }
    [XmlElement(ElementName = "minLoginIdLength", IsNullable = false)]
    public int MinLoginIdLength { get; set; }
 }
}
