using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSessionAdmissionControlGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "restrictAggregateSessions", IsNullable = false)]
    public bool RestrictAggregateSessions { get; set; }
    [XmlElement(ElementName = "maxSessions", IsNullable = false)]
    public int MaxSessions { get; set; }
    [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = false)]
    public int MaxUserOriginatingSessions { get; set; }
    [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = false)]
    public int MaxUserTerminatingSessions { get; set; }
    [XmlElement(ElementName = "countIntraServiceProviderSessions", IsNullable = false)]
    public bool CountIntraServiceProviderSessions { get; set; }
 }
}
