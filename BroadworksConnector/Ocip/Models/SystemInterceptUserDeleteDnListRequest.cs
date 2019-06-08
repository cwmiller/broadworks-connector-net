using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserDeleteDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<string> _phoneNumbers;

    [XmlElement(ElementName = "phoneNumbers", IsNullable = false, Namespace = "")]
    public List<string> PhoneNumbers {
        get => _phoneNumbers;
        set {
            PhoneNumbersSpecified = true;
            _phoneNumbers = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumbersSpecified { get; set; }
}
}
