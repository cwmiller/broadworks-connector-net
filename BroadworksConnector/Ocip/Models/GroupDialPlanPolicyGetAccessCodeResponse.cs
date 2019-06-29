using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDialPlanPolicyGetAccessCodeRequest
    /// <see cref="GroupDialPlanPolicyGetAccessCodeRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:3909""}]")]
    public class GroupDialPlanPolicyGetAccessCodeResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _includeCodeForNetworkTranslationsAndRouting;

        [XmlElement(ElementName = "includeCodeForNetworkTranslationsAndRouting", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3909")]
        public bool IncludeCodeForNetworkTranslationsAndRouting
        {
            get => _includeCodeForNetworkTranslationsAndRouting;
            set
            {
                IncludeCodeForNetworkTranslationsAndRoutingSpecified = true;
                _includeCodeForNetworkTranslationsAndRouting = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeCodeForNetworkTranslationsAndRoutingSpecified { get; set; }

        private bool _includeCodeForScreeningServices;

        [XmlElement(ElementName = "includeCodeForScreeningServices", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3909")]
        public bool IncludeCodeForScreeningServices
        {
            get => _includeCodeForScreeningServices;
            set
            {
                IncludeCodeForScreeningServicesSpecified = true;
                _includeCodeForScreeningServices = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeCodeForScreeningServicesSpecified { get; set; }

        private bool _enableSecondaryDialTone;

        [XmlElement(ElementName = "enableSecondaryDialTone", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3909")]
        public bool EnableSecondaryDialTone
        {
            get => _enableSecondaryDialTone;
            set
            {
                EnableSecondaryDialToneSpecified = true;
                _enableSecondaryDialTone = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSecondaryDialToneSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:3909")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

    }
}
