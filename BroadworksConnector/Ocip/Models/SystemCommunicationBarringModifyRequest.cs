using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _directTransferScreening;

    [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
    public bool DirectTransferScreening {
        get => _directTransferScreening;
        set {
            DirectTransferScreeningSpecified = true;
            _directTransferScreening = value;
        }
    }

    [XmlIgnore]
    public bool DirectTransferScreeningSpecified { get; set; }
    private bool _vmCallbackScreening;

    [XmlElement(ElementName = "vmCallbackScreening", IsNullable = false, Namespace = "")]
    public bool VmCallbackScreening {
        get => _vmCallbackScreening;
        set {
            VmCallbackScreeningSpecified = true;
            _vmCallbackScreening = value;
        }
    }

    [XmlIgnore]
    public bool VmCallbackScreeningSpecified { get; set; }
}
}
