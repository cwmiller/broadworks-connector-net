using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _systemDefaultDomain;

    [XmlElement(ElementName = "systemDefaultDomain", IsNullable = false, Namespace = "")]
    public string SystemDefaultDomain {
        get => _systemDefaultDomain;
        set {
            SystemDefaultDomainSpecified = true;
            _systemDefaultDomain = value;
        }
    }

    [XmlIgnore]
    public bool SystemDefaultDomainSpecified { get; set; }
    private List<string> _domain;

    [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
    public List<string> Domain {
        get => _domain;
        set {
            DomainSpecified = true;
            _domain = value;
        }
    }

    [XmlIgnore]
    public bool DomainSpecified { get; set; }
}
}
