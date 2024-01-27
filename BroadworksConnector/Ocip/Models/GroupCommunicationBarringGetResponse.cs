using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCommunicationBarringGetRequest.
    /// <see cref="GroupCommunicationBarringGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:2761""}]")]
    public class GroupCommunicationBarringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useDefaultServiceProviderProfile;

        [XmlElement(ElementName = "useDefaultServiceProviderProfile", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2761")]
        public bool UseDefaultServiceProviderProfile
        {
            get => _useDefaultServiceProviderProfile;
            set
            {
                UseDefaultServiceProviderProfileSpecified = true;
                _useDefaultServiceProviderProfile = value;
            }
        }

        [XmlIgnore]
        protected bool UseDefaultServiceProviderProfileSpecified { get; set; }

        protected string _profile;

        [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2761")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Profile
        {
            get => _profile;
            set
            {
                ProfileSpecified = true;
                _profile = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileSpecified { get; set; }

    }
}
