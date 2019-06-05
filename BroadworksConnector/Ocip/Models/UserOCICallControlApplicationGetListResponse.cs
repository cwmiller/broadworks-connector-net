using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOCICallControlApplicationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _applicationId;

    [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
    public List<string> ApplicationId {
        get => _applicationId;
        set {
            ApplicationIdSpecified = true;
            _applicationId = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationIdSpecified { get; set; }
}
}
