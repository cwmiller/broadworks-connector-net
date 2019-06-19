using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDialPlanPolicyGetAccessCodeRequest
    /// <see cref="SystemDialPlanPolicyGetAccessCodeRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8072""}]")]
    public class SystemDialPlanPolicyGetAccessCodeResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _includeCodeForNetworkTranslationsAndRouting;

        [XmlElement(ElementName = "includeCodeForNetworkTranslationsAndRouting", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8072")]
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
        public bool IncludeCodeForNetworkTranslationsAndRoutingSpecified { get; set; }

        private bool _includeCodeForScreeningServices;

        [XmlElement(ElementName = "includeCodeForScreeningServices", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8072")]
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
        public bool IncludeCodeForScreeningServicesSpecified { get; set; }

        private bool _enableSecondaryDialTone;

        [XmlElement(ElementName = "enableSecondaryDialTone", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8072")]
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
        public bool EnableSecondaryDialToneSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8072")]
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
        public bool DescriptionSpecified { get; set; }

    }
}
