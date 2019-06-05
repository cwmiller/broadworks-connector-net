using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTrunkGroupOptionsMessageResponseStatusCodeDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<string> _statusCode;

    [XmlElement(ElementName = "statusCode", IsNullable = false, Namespace = "")]
    public List<string> StatusCode {
        get => _statusCode;
        set {
            StatusCodeSpecified = true;
            _statusCode = value;
        }
    }

    [XmlIgnore]
    public bool StatusCodeSpecified { get; set; }
}
}
