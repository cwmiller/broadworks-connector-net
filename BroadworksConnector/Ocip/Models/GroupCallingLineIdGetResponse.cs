using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallingLineIdGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useGroupNumber;

    [XmlElement(ElementName = "useGroupNumber", IsNullable = false, Namespace = "")]
    public bool UseGroupNumber {
        get => _useGroupNumber;
        set {
            UseGroupNumberSpecified = true;
            _useGroupNumber = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupNumberSpecified { get; set; }
    private bool _useGroupName;

    [XmlElement(ElementName = "useGroupName", IsNullable = false, Namespace = "")]
    public bool UseGroupName {
        get => _useGroupName;
        set {
            UseGroupNameSpecified = true;
            _useGroupName = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupNameSpecified { get; set; }
    private string _callingLineIdPhoneNumber;

    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
    public string CallingLineIdPhoneNumber {
        get => _callingLineIdPhoneNumber;
        set {
            CallingLineIdPhoneNumberSpecified = true;
            _callingLineIdPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdPhoneNumberSpecified { get; set; }
    private string _callingLineIdName;

    [XmlElement(ElementName = "callingLineIdName", IsNullable = false, Namespace = "")]
    public string CallingLineIdName {
        get => _callingLineIdName;
        set {
            CallingLineIdNameSpecified = true;
            _callingLineIdName = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdNameSpecified { get; set; }
}
}
