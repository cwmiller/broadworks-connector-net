using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainGetListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.C.OCITable _domainTable;

    [XmlElement(ElementName = "domainTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DomainTable {
        get => _domainTable;
        set {
            DomainTableSpecified = true;
            _domainTable = value;
        }
    }

    [XmlIgnore]
    public bool DomainTableSpecified { get; set; }
}
}
