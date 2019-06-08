using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _profileName;

    [XmlElement(ElementName = "profileName", IsNullable = false, Namespace = "")]
    public string ProfileName {
        get => _profileName;
        set {
            ProfileNameSpecified = true;
            _profileName = value;
        }
    }

    [XmlIgnore]
    public bool ProfileNameSpecified { get; set; }
}
}
