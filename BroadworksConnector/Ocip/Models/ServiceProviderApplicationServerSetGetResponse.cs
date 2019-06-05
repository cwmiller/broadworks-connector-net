using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderApplicationServerSetGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _applicationServerSetName;

    [XmlElement(ElementName = "applicationServerSetName", IsNullable = false, Namespace = "")]
    public string ApplicationServerSetName {
        get => _applicationServerSetName;
        set {
            ApplicationServerSetNameSpecified = true;
            _applicationServerSetName = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationServerSetNameSpecified { get; set; }
}
}
