using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _useAliasForDomain;

    [XmlElement(ElementName = "useAliasForDomain", IsNullable = false, Namespace = "")]
    public bool UseAliasForDomain {
        get => _useAliasForDomain;
        set {
            UseAliasForDomainSpecified = true;
            _useAliasForDomain = value;
        }
    }

    [XmlIgnore]
    public bool UseAliasForDomainSpecified { get; set; }
    private string _defaultDomain;

    [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
    public string DefaultDomain {
        get => _defaultDomain;
        set {
            DefaultDomainSpecified = true;
            _defaultDomain = value;
        }
    }

    [XmlIgnore]
    public bool DefaultDomainSpecified { get; set; }
}
}
