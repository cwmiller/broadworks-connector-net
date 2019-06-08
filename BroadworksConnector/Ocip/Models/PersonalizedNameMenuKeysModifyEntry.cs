using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PersonalizedNameMenuKeysModifyEntry 
{
    private string _recordNewPersonalizedName;

    [XmlElement(ElementName = "recordNewPersonalizedName", IsNullable = true, Namespace = "")]
    public string RecordNewPersonalizedName {
        get => _recordNewPersonalizedName;
        set {
            RecordNewPersonalizedNameSpecified = true;
            _recordNewPersonalizedName = value;
        }
    }

    [XmlIgnore]
    public bool RecordNewPersonalizedNameSpecified { get; set; }
    private string _listenToCurrentPersonalizedName;

    [XmlElement(ElementName = "listenToCurrentPersonalizedName", IsNullable = true, Namespace = "")]
    public string ListenToCurrentPersonalizedName {
        get => _listenToCurrentPersonalizedName;
        set {
            ListenToCurrentPersonalizedNameSpecified = true;
            _listenToCurrentPersonalizedName = value;
        }
    }

    [XmlIgnore]
    public bool ListenToCurrentPersonalizedNameSpecified { get; set; }
    private string _deletePersonalizedName;

    [XmlElement(ElementName = "deletePersonalizedName", IsNullable = true, Namespace = "")]
    public string DeletePersonalizedName {
        get => _deletePersonalizedName;
        set {
            DeletePersonalizedNameSpecified = true;
            _deletePersonalizedName = value;
        }
    }

    [XmlIgnore]
    public bool DeletePersonalizedNameSpecified { get; set; }
    private string _returnToPreviousMenu;

    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
    public string ReturnToPreviousMenu {
        get => _returnToPreviousMenu;
        set {
            ReturnToPreviousMenuSpecified = true;
            _returnToPreviousMenu = value;
        }
    }

    [XmlIgnore]
    public bool ReturnToPreviousMenuSpecified { get; set; }
    private string _repeatMenu;

    [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
    public string RepeatMenu {
        get => _repeatMenu;
        set {
            RepeatMenuSpecified = true;
            _repeatMenu = value;
        }
    }

    [XmlIgnore]
    public bool RepeatMenuSpecified { get; set; }
}
}
