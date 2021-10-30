using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the configuration for a call processing policy profile Voice Portal subscriber type profile.
    /// The response is either a SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22 or an
    /// ErrorResponse.
    /// Replaced by: SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22V2.
    /// <see cref="SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24197""}]")]
    public class SystemCallProcessingPolicyProfileVoicePortalProfileGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallProcessingPolicyProfileVoicePortalProfileGetResponse22>
    {

        private string _callProcessingPolicyProfileName;

        [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24197")]
        [MinLength(1)]
        [MaxLength(40)]
        public string CallProcessingPolicyProfileName
        {
            get => _callProcessingPolicyProfileName;
            set
            {
                CallProcessingPolicyProfileNameSpecified = true;
                _callProcessingPolicyProfileName = value;
            }
        }

        [XmlIgnore]
        protected bool CallProcessingPolicyProfileNameSpecified { get; set; }

    }
}
