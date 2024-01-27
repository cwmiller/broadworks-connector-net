using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDialPlanPolicyGetAccessCodeRequest
    /// <see cref="ServiceProviderDialPlanPolicyGetAccessCodeRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3704""}]")]
    public class ServiceProviderDialPlanPolicyGetAccessCodeResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _includeCodeForNetworkTranslationsAndRouting;

        [XmlElement(ElementName = "includeCodeForNetworkTranslationsAndRouting", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3704")]
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

        protected bool _includeCodeForScreeningServices;

        [XmlElement(ElementName = "includeCodeForScreeningServices", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3704")]
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

        protected bool _enableSecondaryDialTone;

        [XmlElement(ElementName = "enableSecondaryDialTone", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3704")]
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

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3704")]
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
