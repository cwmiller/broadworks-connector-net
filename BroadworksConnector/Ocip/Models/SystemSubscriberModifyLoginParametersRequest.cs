using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSubscriberModifyLoginParametersRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false)]
    public int MaxFailedLoginAttempts { get; set; }
    [XmlElement(ElementName = "minLoginIdLength", IsNullable = false)]
    public int MinLoginIdLength { get; set; }
 }
}
