using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSessionAdmissionControlGetResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false)]
    public bool CountLongConnectionsToMediaServer { get; set; }
    [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType SacHandlingForMoH { get; set; }
    [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false)]
    public bool BlockVMDepositDueToSACLimits { get; set; }
    [XmlElement(ElementName = "sacCodecSelectionPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType SacCodecSelectionPolicy { get; set; }
 }
}
