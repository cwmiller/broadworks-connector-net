using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseSessionAdmissionControlGroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "newName", IsNullable = false)]
    public string NewName { get; set; }
    [XmlElement(ElementName = "maxSession", IsNullable = false)]
    public int MaxSession { get; set; }
    [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = true)]
    public int? MaxUserOriginatingSessions { get; set; }
    [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = true)]
    public int? MaxUserTerminatingSessions { get; set; }
    [XmlElement(ElementName = "reservedSession", IsNullable = false)]
    public int ReservedSession { get; set; }
    [XmlElement(ElementName = "reservedUserOriginatingSessions", IsNullable = true)]
    public int? ReservedUserOriginatingSessions { get; set; }
    [XmlElement(ElementName = "reservedUserTerminatingSessions", IsNullable = true)]
    public int? ReservedUserTerminatingSessions { get; set; }
    [XmlElement(ElementName = "becomeDefaultGroup", IsNullable = false)]
    public bool BecomeDefaultGroup { get; set; }
    [XmlElement(ElementName = "countIntraSACGroupSessions", IsNullable = false)]
    public bool CountIntraSACGroupSessions { get; set; }
    [XmlElement(ElementName = "deviceList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementEnterpriseDeviceList DeviceList { get; set; }
    [XmlElement(ElementName = "blockEmergencyAndRepairCallsDueToSACLimits", IsNullable = false)]
    public bool BlockEmergencyAndRepairCallsDueToSACLimits { get; set; }
    [XmlElement(ElementName = "mediaGroupName", IsNullable = true)]
    public string MediaGroupName { get; set; }
    [XmlElement(ElementName = "accessInfoPattern", IsNullable = true)]
    public string AccessInfoPattern { get; set; }
 }
}
