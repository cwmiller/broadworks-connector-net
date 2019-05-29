using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSessionAdmissionControlModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "restrictAggregateSessions", IsNullable = false)]
    public bool RestrictAggregateSessions { get; set; }
    [XmlElement(ElementName = "maxSessions", IsNullable = true)]
    public int? MaxSessions { get; set; }
    [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = true)]
    public int? MaxUserOriginatingSessions { get; set; }
    [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = true)]
    public int? MaxUserTerminatingSessions { get; set; }
    [XmlElement(ElementName = "countIntraServiceProviderSessions", IsNullable = false)]
    public bool CountIntraServiceProviderSessions { get; set; }
 }
}
