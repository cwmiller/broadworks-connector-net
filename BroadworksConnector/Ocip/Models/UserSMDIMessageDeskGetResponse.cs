using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSMDIMessageDeskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private string _messageDeskNumber;

    [XmlElement(ElementName = "messageDeskNumber", IsNullable = false, Namespace = "")]
    public string MessageDeskNumber {
        get => _messageDeskNumber;
        set {
            MessageDeskNumberSpecified = true;
            _messageDeskNumber = value;
        }
    }

    [XmlIgnore]
    public bool MessageDeskNumberSpecified { get; set; }
}
}
