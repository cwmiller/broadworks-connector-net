using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHPBXAlternateCarrierSelectionModifyCarrierRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _prefix;

    [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
    public string Prefix {
        get => _prefix;
        set {
            PrefixSpecified = true;
            _prefix = value;
        }
    }

    [XmlIgnore]
    public bool PrefixSpecified { get; set; }
    private string _domain;

    [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
    public string Domain {
        get => _domain;
        set {
            DomainSpecified = true;
            _domain = value;
        }
    }

    [XmlIgnore]
    public bool DomainSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.HPBXAlternateCarrierType _type;

    [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HPBXAlternateCarrierType Type {
        get => _type;
        set {
            TypeSpecified = true;
            _type = value;
        }
    }

    [XmlIgnore]
    public bool TypeSpecified { get; set; }
}
}
