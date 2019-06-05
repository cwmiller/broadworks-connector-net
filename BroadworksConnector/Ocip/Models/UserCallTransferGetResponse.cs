using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallTransferGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isRecallActive;

    [XmlElement(ElementName = "isRecallActive", IsNullable = false, Namespace = "")]
    public bool IsRecallActive {
        get => _isRecallActive;
        set {
            IsRecallActiveSpecified = true;
            _isRecallActive = value;
        }
    }

    [XmlIgnore]
    public bool IsRecallActiveSpecified { get; set; }
    private int _recallNumberOfRings;

    [XmlElement(ElementName = "recallNumberOfRings", IsNullable = false, Namespace = "")]
    public int RecallNumberOfRings {
        get => _recallNumberOfRings;
        set {
            RecallNumberOfRingsSpecified = true;
            _recallNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool RecallNumberOfRingsSpecified { get; set; }
    private bool _useDiversionInhibitorForBlindTransfer;

    [XmlElement(ElementName = "useDiversionInhibitorForBlindTransfer", IsNullable = false, Namespace = "")]
    public bool UseDiversionInhibitorForBlindTransfer {
        get => _useDiversionInhibitorForBlindTransfer;
        set {
            UseDiversionInhibitorForBlindTransferSpecified = true;
            _useDiversionInhibitorForBlindTransfer = value;
        }
    }

    [XmlIgnore]
    public bool UseDiversionInhibitorForBlindTransferSpecified { get; set; }
    private bool _useDiversionInhibitorForConsultativeCalls;

    [XmlElement(ElementName = "useDiversionInhibitorForConsultativeCalls", IsNullable = false, Namespace = "")]
    public bool UseDiversionInhibitorForConsultativeCalls {
        get => _useDiversionInhibitorForConsultativeCalls;
        set {
            UseDiversionInhibitorForConsultativeCallsSpecified = true;
            _useDiversionInhibitorForConsultativeCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseDiversionInhibitorForConsultativeCallsSpecified { get; set; }
}
}
