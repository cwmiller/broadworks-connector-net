using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceCodeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceCode;

    [XmlElement(ElementName = "serviceCode", IsNullable = false, Namespace = "")]
    public string ServiceCode {
        get => _serviceCode;
        set {
            ServiceCodeSpecified = true;
            _serviceCode = value;
        }
    }

    [XmlIgnore]
    public bool ServiceCodeSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
}
}
