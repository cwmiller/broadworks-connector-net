using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseSessionAdmissionControlGroupGetResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxSession", IsNullable = false)]
    public int MaxSession { get; set; }
    [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = false)]
    public int MaxUserOriginatingSessions { get; set; }
    [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = false)]
    public int MaxUserTerminatingSessions { get; set; }
    [XmlElement(ElementName = "reservedSession", IsNullable = false)]
    public int ReservedSession { get; set; }
    [XmlElement(ElementName = "reservedUserOriginatingSessions", IsNullable = false)]
    public int ReservedUserOriginatingSessions { get; set; }
    [XmlElement(ElementName = "reservedUserTerminatingSessions", IsNullable = false)]
    public int ReservedUserTerminatingSessions { get; set; }
    [XmlElement(ElementName = "defaultGroup", IsNullable = false)]
    public bool DefaultGroup { get; set; }
    [XmlElement(ElementName = "countIntraSACGroupSessions", IsNullable = false)]
    public bool CountIntraSACGroupSessions { get; set; }
    [XmlElement(ElementName = "devices", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseAccessDevice> Devices { get; set; }
    [XmlElement(ElementName = "blockEmergencyAndRepairCallsDueToSACLimits", IsNullable = false)]
    public bool BlockEmergencyAndRepairCallsDueToSACLimits { get; set; }
 }
}
