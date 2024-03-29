using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserNetworkConferencingGetRequest.
    /// <see cref="UserNetworkConferencingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2640""}]")]
    public class UserNetworkConferencingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _conferenceURI;

        [XmlElement(ElementName = "conferenceURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2640")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ConferenceURI
        {
            get => _conferenceURI;
            set
            {
                ConferenceURISpecified = true;
                _conferenceURI = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceURISpecified { get; set; }

        protected int _maxConferenceParties;

        [XmlElement(ElementName = "maxConferenceParties", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2640")]
        [MinInclusive(4)]
        [MaxInclusive(15)]
        public int MaxConferenceParties
        {
            get => _maxConferenceParties;
            set
            {
                MaxConferencePartiesSpecified = true;
                _maxConferenceParties = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConferencePartiesSpecified { get; set; }

    }
}
