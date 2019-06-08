using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallMeNowToDnCriteriaModify 
{
    private BroadWorksConnector.Ocip.Models.CriteriaDnSelection _toDnCriteriaSelection;

    [XmlElement(ElementName = "toDnCriteriaSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CriteriaDnSelection ToDnCriteriaSelection {
        get => _toDnCriteriaSelection;
        set {
            ToDnCriteriaSelectionSpecified = true;
            _toDnCriteriaSelection = value;
        }
    }

    [XmlIgnore]
    public bool ToDnCriteriaSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList _phoneNumberList;

    [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList PhoneNumberList {
        get => _phoneNumberList;
        set {
            PhoneNumberListSpecified = true;
            _phoneNumberList = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberListSpecified { get; set; }
}
}
