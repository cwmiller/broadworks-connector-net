using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointQueueCallDispositionCodeGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private string _code;

    [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
    public string Code {
        get => _code;
        set {
            CodeSpecified = true;
            _code = value;
        }
    }

    [XmlIgnore]
    public bool CodeSpecified { get; set; }
}
}
