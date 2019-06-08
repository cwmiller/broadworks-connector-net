using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class Contact 
{
    private string _contactName;

    [XmlElement(ElementName = "contactName", IsNullable = true, Namespace = "")]
    public string ContactName {
        get => _contactName;
        set {
            ContactNameSpecified = true;
            _contactName = value;
        }
    }

    [XmlIgnore]
    public bool ContactNameSpecified { get; set; }
    private string _contactNumber;

    [XmlElement(ElementName = "contactNumber", IsNullable = true, Namespace = "")]
    public string ContactNumber {
        get => _contactNumber;
        set {
            ContactNumberSpecified = true;
            _contactNumber = value;
        }
    }

    [XmlIgnore]
    public bool ContactNumberSpecified { get; set; }
    private string _contactEmail;

    [XmlElement(ElementName = "contactEmail", IsNullable = true, Namespace = "")]
    public string ContactEmail {
        get => _contactEmail;
        set {
            ContactEmailSpecified = true;
            _contactEmail = value;
        }
    }

    [XmlIgnore]
    public bool ContactEmailSpecified { get; set; }
}
}
