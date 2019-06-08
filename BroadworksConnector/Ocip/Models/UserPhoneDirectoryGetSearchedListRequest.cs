using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPhoneDirectoryGetSearchedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _nameSearchString;

    [XmlElement(ElementName = "nameSearchString", IsNullable = false, Namespace = "")]
    public string NameSearchString {
        get => _nameSearchString;
        set {
            NameSearchStringSpecified = true;
            _nameSearchString = value;
        }
    }

    [XmlIgnore]
    public bool NameSearchStringSpecified { get; set; }
}
}
