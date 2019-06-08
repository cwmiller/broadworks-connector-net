using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringDigitPatternCriteriaModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private List<string> _addMatchDigitPattern;

    [XmlElement(ElementName = "addMatchDigitPattern", IsNullable = false, Namespace = "")]
    public List<string> AddMatchDigitPattern {
        get => _addMatchDigitPattern;
        set {
            AddMatchDigitPatternSpecified = true;
            _addMatchDigitPattern = value;
        }
    }

    [XmlIgnore]
    public bool AddMatchDigitPatternSpecified { get; set; }
    private List<string> _deleteMatchDigitPattern;

    [XmlElement(ElementName = "deleteMatchDigitPattern", IsNullable = false, Namespace = "")]
    public List<string> DeleteMatchDigitPattern {
        get => _deleteMatchDigitPattern;
        set {
            DeleteMatchDigitPatternSpecified = true;
            _deleteMatchDigitPattern = value;
        }
    }

    [XmlIgnore]
    public bool DeleteMatchDigitPatternSpecified { get; set; }
}
}
