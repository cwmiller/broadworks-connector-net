using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSessionAdmissionControlGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _countLongConnectionsToMediaServer;

    [XmlElement(ElementName = "countLongConnectionsToMediaServer", IsNullable = false, Namespace = "")]
    public bool CountLongConnectionsToMediaServer {
        get => _countLongConnectionsToMediaServer;
        set {
            CountLongConnectionsToMediaServerSpecified = true;
            _countLongConnectionsToMediaServer = value;
        }
    }

    [XmlIgnore]
    public bool CountLongConnectionsToMediaServerSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType _sacHandlingForMoH;

    [XmlElement(ElementName = "sacHandlingForMoH", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SessionAdmissionControlForMusicOnHoldType SacHandlingForMoH {
        get => _sacHandlingForMoH;
        set {
            SacHandlingForMoHSpecified = true;
            _sacHandlingForMoH = value;
        }
    }

    [XmlIgnore]
    public bool SacHandlingForMoHSpecified { get; set; }
    private bool _blockVMDepositDueToSACLimits;

    [XmlElement(ElementName = "blockVMDepositDueToSACLimits", IsNullable = false, Namespace = "")]
    public bool BlockVMDepositDueToSACLimits {
        get => _blockVMDepositDueToSACLimits;
        set {
            BlockVMDepositDueToSACLimitsSpecified = true;
            _blockVMDepositDueToSACLimits = value;
        }
    }

    [XmlIgnore]
    public bool BlockVMDepositDueToSACLimitsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType _sacCodecSelectionPolicy;

    [XmlElement(ElementName = "sacCodecSelectionPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SessionAdmissionControlCodecSelectionPolicyType SacCodecSelectionPolicy {
        get => _sacCodecSelectionPolicy;
        set {
            SacCodecSelectionPolicySpecified = true;
            _sacCodecSelectionPolicy = value;
        }
    }

    [XmlIgnore]
    public bool SacCodecSelectionPolicySpecified { get; set; }
}
}
