using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVerifyTranslationAndRoutingResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _result;

    [XmlElement(ElementName = "Result", IsNullable = false, Namespace = "")]
    public string Result {
        get => _result;
        set {
            ResultSpecified = true;
            _result = value;
        }
    }

    [XmlIgnore]
    public bool ResultSpecified { get; set; }
}
}
