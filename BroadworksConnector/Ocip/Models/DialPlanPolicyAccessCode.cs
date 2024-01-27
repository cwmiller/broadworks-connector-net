using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Dial Plan Access Code attributes.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:2915""}]")]
    public class DialPlanPolicyAccessCode
    {

        protected string _accessCode;

        [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2915")]
        [MinLength(1)]
        [MaxLength(5)]
        public string AccessCode
        {
            get => _accessCode;
            set
            {
                AccessCodeSpecified = true;
                _accessCode = value;
            }
        }

        [XmlIgnore]
        protected bool AccessCodeSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2915")]
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

        protected bool _includeCodeForNetworkTranslationsAndRouting;

        [XmlElement(ElementName = "includeCodeForNetworkTranslationsAndRouting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2915")]
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
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2915")]
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
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:2915")]
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

    }
}
