using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMGCPDeviceTypeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isObsolete;

    [XmlElement(ElementName = "isObsolete", IsNullable = false, Namespace = "")]
    public bool IsObsolete {
        get => _isObsolete;
        set {
            IsObsoleteSpecified = true;
            _isObsolete = value;
        }
    }

    [XmlIgnore]
    public bool IsObsoleteSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SignalingAddressType _profile;

    [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SignalingAddressType Profile {
        get => _profile;
        set {
            ProfileSpecified = true;
            _profile = value;
        }
    }

    [XmlIgnore]
    public bool ProfileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _numberOfPorts;

    [XmlElement(ElementName = "numberOfPorts", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt NumberOfPorts {
        get => _numberOfPorts;
        set {
            NumberOfPortsSpecified = true;
            _numberOfPorts = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfPortsSpecified { get; set; }
    private List<string> _protocolChoice;

    [XmlElement(ElementName = "protocolChoice", IsNullable = false, Namespace = "")]
    public List<string> ProtocolChoice {
        get => _protocolChoice;
        set {
            ProtocolChoiceSpecified = true;
            _protocolChoice = value;
        }
    }

    [XmlIgnore]
    public bool ProtocolChoiceSpecified { get; set; }
}
}
