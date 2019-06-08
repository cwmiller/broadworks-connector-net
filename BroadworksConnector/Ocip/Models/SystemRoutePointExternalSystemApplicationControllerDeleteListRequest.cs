using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutePointExternalSystemApplicationControllerDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _applicationController;

    [XmlElement(ElementName = "applicationController", IsNullable = false, Namespace = "")]
    public List<string> ApplicationController {
        get => _applicationController;
        set {
            ApplicationControllerSpecified = true;
            _applicationController = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationControllerSpecified { get; set; }
}
}
