using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class NameDialingName 
{
    private string _nameDialingLastName;

    [XmlElement(ElementName = "nameDialingLastName", IsNullable = false, Namespace = "")]
    public string NameDialingLastName {
        get => _nameDialingLastName;
        set {
            NameDialingLastNameSpecified = true;
            _nameDialingLastName = value;
        }
    }

    [XmlIgnore]
    public bool NameDialingLastNameSpecified { get; set; }
    private string _nameDialingFirstName;

    [XmlElement(ElementName = "nameDialingFirstName", IsNullable = false, Namespace = "")]
    public string NameDialingFirstName {
        get => _nameDialingFirstName;
        set {
            NameDialingFirstNameSpecified = true;
            _nameDialingFirstName = value;
        }
    }

    [XmlIgnore]
    public bool NameDialingFirstNameSpecified { get; set; }
}
}
