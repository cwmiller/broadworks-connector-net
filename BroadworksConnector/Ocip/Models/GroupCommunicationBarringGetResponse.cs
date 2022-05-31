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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3035""}]")]
    public class GroupCommunicationBarringGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useDefaultServiceProviderProfile;

        [XmlElement(ElementName = "useDefaultServiceProviderProfile", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3035")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3035")]
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
