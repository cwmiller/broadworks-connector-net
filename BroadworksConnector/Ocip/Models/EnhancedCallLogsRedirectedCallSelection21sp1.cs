using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsRedirectedCallSelection21sp1 
{
    private bool _redirectedCall;

    [XmlElement(ElementName = "redirectedCall", IsNullable = false, Namespace = "")]
    public bool RedirectedCall {
        get => _redirectedCall;
        set {
            RedirectedCallSpecified = true;
            _redirectedCall = value;
        }
    }

    [XmlIgnore]
    public bool RedirectedCallSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21sp1> _redirectType;

    [XmlElement(ElementName = "redirectType", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21sp1> RedirectType {
        get => _redirectType;
        set {
            RedirectTypeSpecified = true;
            _redirectType = value;
        }
    }

    [XmlIgnore]
    public bool RedirectTypeSpecified { get; set; }
}
}
