using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingModifyChargingFunctionElementServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ChargingFunctionElementServerType _type;

    [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ChargingFunctionElementServerType Type {
        get => _type;
        set {
            TypeSpecified = true;
            _type = value;
        }
    }

    [XmlIgnore]
    public bool TypeSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
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
