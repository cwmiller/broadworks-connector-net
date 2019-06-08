using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _status;

    [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
    public string Status {
        get => _status;
        set {
            StatusSpecified = true;
            _status = value;
        }
    }

    [XmlIgnore]
    public bool StatusSpecified { get; set; }
}
}
