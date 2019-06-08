using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaGroupCodecDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _codecName;

    [XmlElement(ElementName = "codecName", IsNullable = false, Namespace = "")]
    public string CodecName {
        get => _codecName;
        set {
            CodecNameSpecified = true;
            _codecName = value;
        }
    }

    [XmlIgnore]
    public bool CodecNameSpecified { get; set; }
}
}
