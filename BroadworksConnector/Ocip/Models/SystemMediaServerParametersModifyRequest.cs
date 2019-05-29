using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaServerParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mediaServerResponseTimerMilliseconds", IsNullable = false)]
    public int MediaServerResponseTimerMilliseconds { get; set; }
    [XmlElement(ElementName = "mediaServerSelectionRouteTimerMilliseconds", IsNullable = false)]
    public int MediaServerSelectionRouteTimerMilliseconds { get; set; }
    [XmlElement(ElementName = "useStaticMediaServerDevice", IsNullable = false)]
    public bool UseStaticMediaServerDevice { get; set; }
 }
}
