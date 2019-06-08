using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingAddChargingFunctionElementServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _address;

    [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
    public string Address {
        get => _address;
        set {
            AddressSpecified = true;
            _address = value;
        }
    }

    [XmlIgnore]
    public bool AddressSpecified { get; set; }
    private bool _isNetAddressExtended;

    [XmlElement(ElementName = "isNetAddressExtended", IsNullable = false, Namespace = "")]
    public bool IsNetAddressExtended {
        get => _isNetAddressExtended;
        set {
            IsNetAddressExtendedSpecified = true;
            _isNetAddressExtended = value;
        }
    }

    [XmlIgnore]
    public bool IsNetAddressExtendedSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ChargingFunctionElementServerType _type;

    [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ChargingFunctionElementServerType Type {
        get => _type;
        set {
            TypeSpecified = true;
            _type = value;
        }
    }

    [XmlIgnore]
    public bool TypeSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
}
}
