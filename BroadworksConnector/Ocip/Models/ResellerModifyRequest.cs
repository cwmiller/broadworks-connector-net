using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
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
    private string _resellerName;

    [XmlElement(ElementName = "resellerName", IsNullable = true, Namespace = "")]
    public string ResellerName {
        get => _resellerName;
        set {
            ResellerNameSpecified = true;
            _resellerName = value;
        }
    }

    [XmlIgnore]
    public bool ResellerNameSpecified { get; set; }
}
}
