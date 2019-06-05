using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserConsolidatedDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _deleteExistingDevices;

    [XmlElement(ElementName = "deleteExistingDevices", IsNullable = false, Namespace = "")]
    public bool DeleteExistingDevices {
        get => _deleteExistingDevices;
        set {
            DeleteExistingDevicesSpecified = true;
            _deleteExistingDevices = value;
        }
    }

    [XmlIgnore]
    public bool DeleteExistingDevicesSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UnassignPhoneNumbersLevel _unassignPhoneNumbers;

    [XmlElement(ElementName = "unassignPhoneNumbers", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UnassignPhoneNumbersLevel UnassignPhoneNumbers {
        get => _unassignPhoneNumbers;
        set {
            UnassignPhoneNumbersSpecified = true;
            _unassignPhoneNumbers = value;
        }
    }

    [XmlIgnore]
    public bool UnassignPhoneNumbersSpecified { get; set; }
}
}
