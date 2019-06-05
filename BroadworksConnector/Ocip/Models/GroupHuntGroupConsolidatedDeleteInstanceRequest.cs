using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupConsolidatedDeleteInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
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
