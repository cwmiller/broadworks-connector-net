using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DNRange 
{
    private string _minPhoneNumber;

    [XmlElement(ElementName = "minPhoneNumber", IsNullable = false, Namespace = "")]
    public string MinPhoneNumber {
        get => _minPhoneNumber;
        set {
            MinPhoneNumberSpecified = true;
            _minPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool MinPhoneNumberSpecified { get; set; }
    private string _maxPhoneNumber;

    [XmlElement(ElementName = "maxPhoneNumber", IsNullable = false, Namespace = "")]
    public string MaxPhoneNumber {
        get => _maxPhoneNumber;
        set {
            MaxPhoneNumberSpecified = true;
            _maxPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool MaxPhoneNumberSpecified { get; set; }
}
}
