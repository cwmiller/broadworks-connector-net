using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserNetworkConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _conferenceURI;

    [XmlElement(ElementName = "conferenceURI", IsNullable = false, Namespace = "")]
    public string ConferenceURI {
        get => _conferenceURI;
        set {
            ConferenceURISpecified = true;
            _conferenceURI = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceURISpecified { get; set; }
    private int _maxConferenceParties;

    [XmlElement(ElementName = "maxConferenceParties", IsNullable = false, Namespace = "")]
    public int MaxConferenceParties {
        get => _maxConferenceParties;
        set {
            MaxConferencePartiesSpecified = true;
            _maxConferenceParties = value;
        }
    }

    [XmlIgnore]
    public bool MaxConferencePartiesSpecified { get; set; }
}
}
