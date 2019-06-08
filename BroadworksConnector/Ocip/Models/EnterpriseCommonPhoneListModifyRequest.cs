using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCommonPhoneListModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _entryName;

    [XmlElement(ElementName = "entryName", IsNullable = false, Namespace = "")]
    public string EntryName {
        get => _entryName;
        set {
            EntryNameSpecified = true;
            _entryName = value;
        }
    }

    [XmlIgnore]
    public bool EntryNameSpecified { get; set; }
    private string _newEntryName;

    [XmlElement(ElementName = "newEntryName", IsNullable = false, Namespace = "")]
    public string NewEntryName {
        get => _newEntryName;
        set {
            NewEntryNameSpecified = true;
            _newEntryName = value;
        }
    }

    [XmlIgnore]
    public bool NewEntryNameSpecified { get; set; }
    private string _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
}
}
