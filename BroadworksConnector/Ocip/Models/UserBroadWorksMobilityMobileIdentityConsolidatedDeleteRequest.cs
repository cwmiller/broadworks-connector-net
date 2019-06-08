using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksMobilityMobileIdentityConsolidatedDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _mobileNumber;

    [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
    public string MobileNumber {
        get => _mobileNumber;
        set {
            MobileNumberSpecified = true;
            _mobileNumber = value;
        }
    }

    [XmlIgnore]
    public bool MobileNumberSpecified { get; set; }
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
}
}
