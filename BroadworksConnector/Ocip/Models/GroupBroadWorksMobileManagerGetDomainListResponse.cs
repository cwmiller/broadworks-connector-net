using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobileManagerGetDomainListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _domainName;

    [XmlElement(ElementName = "domainName", IsNullable = false, Namespace = "")]
    public List<string> DomainName {
        get => _domainName;
        set {
            DomainNameSpecified = true;
            _domainName = value;
        }
    }

    [XmlIgnore]
    public bool DomainNameSpecified { get; set; }
}
}
