using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoiceMessagingDistributionListModify 
{
    private int _listId;

    [XmlElement(ElementName = "listId", IsNullable = false, Namespace = "")]
    public int ListId {
        get => _listId;
        set {
            ListIdSpecified = true;
            _listId = value;
        }
    }

    [XmlIgnore]
    public bool ListIdSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList _phoneNumberList;

    [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList PhoneNumberList {
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
