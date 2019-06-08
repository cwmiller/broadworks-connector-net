using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserNumberPortabilityAnnouncementGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enable;

    [XmlElement(ElementName = "enable", IsNullable = false, Namespace = "")]
    public bool Enable {
        get => _enable;
        set {
            EnableSpecified = true;
            _enable = value;
        }
    }

    [XmlIgnore]
    public bool EnableSpecified { get; set; }
}
}
