using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class BroadWorksMobilityAlertingMobileNumberReplacementList 
{
    private List<string> _mobileNumber;

    [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
    public List<string> MobileNumber {
        get => _mobileNumber;
        set {
            MobileNumberSpecified = true;
            _mobileNumber = value;
        }
    }

    [XmlIgnore]
    public bool MobileNumberSpecified { get; set; }
}
}
