using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDomainGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _excludeReseller;

    [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
    public bool ExcludeReseller {
        get => _excludeReseller;
        set {
            ExcludeResellerSpecified = true;
            _excludeReseller = value;
        }
    }

    [XmlIgnore]
    public bool ExcludeResellerSpecified { get; set; }
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
}
}
