using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskAddRequestUserPhoneNumbers 
{
    private List<string> _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public List<string> PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.DNRange> _dnRange;

    [XmlElement(ElementName = "dnRange", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.DNRange> DnRange {
        get => _dnRange;
        set {
            DnRangeSpecified = true;
            _dnRange = value;
        }
    }

    [XmlIgnore]
    public bool DnRangeSpecified { get; set; }
}
}
