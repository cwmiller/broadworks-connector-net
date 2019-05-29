using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSessionAdmissionControlGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false)]
    public bool CountLongConnectionsToMediaServer { get; set; }
    [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType SacHandlingForMoH { get; set; }
    [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false)]
    public bool BlockVMDepositDueToSACLimits { get; set; }
    [XmlElement(ElementName = "sacCodecSelectionPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType SacCodecSelectionPolicy { get; set; }
    [XmlElement(ElementName = "countCallToMobileNumberForSACSubscriber", IsNullable = false)]
    public bool CountCallToMobileNumberForSACSubscriber { get; set; }
    [XmlElement(ElementName = "countBWAnywhereForSACSubscriber", IsNullable = false)]
    public bool CountBWAnywhereForSACSubscriber { get; set; }
    [XmlElement(ElementName = "countROForSACSubscriber", IsNullable = false)]
    public bool CountROForSACSubscriber { get; set; }
    [XmlElement(ElementName = "excludeBWMobilityForSACSubscriber", IsNullable = false)]
    public bool ExcludeBWMobilityForSACSubscriber { get; set; }
 }
}
