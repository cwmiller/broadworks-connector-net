using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSessionAdmissionControlWhiteListModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _enableWhiteList;

    [XmlElement(ElementName = "enableWhiteList", IsNullable = false, Namespace = "")]
    public bool EnableWhiteList {
        get => _enableWhiteList;
        set {
            EnableWhiteListSpecified = true;
            _enableWhiteList = value;
        }
    }

    [XmlIgnore]
    public bool EnableWhiteListSpecified { get; set; }
}
}
