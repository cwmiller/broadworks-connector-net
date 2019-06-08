using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _systemDefaultTagSet;

    [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false, Namespace = "")]
    public bool SystemDefaultTagSet {
        get => _systemDefaultTagSet;
        set {
            SystemDefaultTagSetSpecified = true;
            _systemDefaultTagSet = value;
        }
    }

    [XmlIgnore]
    public bool SystemDefaultTagSetSpecified { get; set; }
    private string _tagSetName;

    [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
    public string TagSetName {
        get => _tagSetName;
        set {
            TagSetNameSpecified = true;
            _tagSetName = value;
        }
    }

    [XmlIgnore]
    public bool TagSetNameSpecified { get; set; }
    private string _tagName;

    [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
    public string TagName {
        get => _tagName;
        set {
            TagNameSpecified = true;
            _tagName = value;
        }
    }

    [XmlIgnore]
    public bool TagNameSpecified { get; set; }
    private string _tagValue;

    [XmlElement(ElementName = "tagValue", IsNullable = true, Namespace = "")]
    public string TagValue {
        get => _tagValue;
        set {
            TagValueSpecified = true;
            _tagValue = value;
        }
    }

    [XmlIgnore]
    public bool TagValueSpecified { get; set; }
    private string _tagValueToEncrypt;

    [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = true, Namespace = "")]
    public string TagValueToEncrypt {
        get => _tagValueToEncrypt;
        set {
            TagValueToEncryptSpecified = true;
            _tagValueToEncrypt = value;
        }
    }

    [XmlIgnore]
    public bool TagValueToEncryptSpecified { get; set; }
    private bool _isTagValueOverridable;

    [XmlElement(ElementName = "isTagValueOverridable", IsNullable = false, Namespace = "")]
    public bool IsTagValueOverridable {
        get => _isTagValueOverridable;
        set {
            IsTagValueOverridableSpecified = true;
            _isTagValueOverridable = value;
        }
    }

    [XmlIgnore]
    public bool IsTagValueOverridableSpecified { get; set; }
}
}
