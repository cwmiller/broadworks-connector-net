using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest.
    /// 
    /// Replaced by EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4.
    /// <see cref="EnterpriseCallCenterAgentUnavailableCodeSettingsGetRequest"/>
    /// <see cref="EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24147""}]")]
    public class EnterpriseCallCenterAgentUnavailableCodeSettingsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableAgentUnavailableCodes;

        [XmlElement(ElementName = "enableAgentUnavailableCodes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24147")]
        public bool EnableAgentUnavailableCodes
        {
            get => _enableAgentUnavailableCodes;
            set
            {
                EnableAgentUnavailableCodesSpecified = true;
                _enableAgentUnavailableCodes = value;
            }
        }

        [XmlIgnore]
        public bool EnableAgentUnavailableCodesSpecified { get; set; }

        private string _defaultAgentUnavailableCodeOnDND;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnDND", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24147")]
        [MinLength(1)]
        [MaxLength(10)]
        public string DefaultAgentUnavailableCodeOnDND
        {
            get => _defaultAgentUnavailableCodeOnDND;
            set
            {
                DefaultAgentUnavailableCodeOnDNDSpecified = true;
                _defaultAgentUnavailableCodeOnDND = value;
            }
        }

        [XmlIgnore]
        public bool DefaultAgentUnavailableCodeOnDNDSpecified { get; set; }

        private string _defaultAgentUnavailableCodeOnPersonalCalls;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnPersonalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24147")]
        [MinLength(1)]
        [MaxLength(10)]
        public string DefaultAgentUnavailableCodeOnPersonalCalls
        {
            get => _defaultAgentUnavailableCodeOnPersonalCalls;
            set
            {
                DefaultAgentUnavailableCodeOnPersonalCallsSpecified = true;
                _defaultAgentUnavailableCodeOnPersonalCalls = value;
            }
        }

        [XmlIgnore]
        public bool DefaultAgentUnavailableCodeOnPersonalCallsSpecified { get; set; }

        private string _defaultAgentUnavailableCodeOnConsecutiveBounces;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnConsecutiveBounces", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24147")]
        [MinLength(1)]
        [MaxLength(10)]
        public string DefaultAgentUnavailableCodeOnConsecutiveBounces
        {
            get => _defaultAgentUnavailableCodeOnConsecutiveBounces;
            set
            {
                DefaultAgentUnavailableCodeOnConsecutiveBouncesSpecified = true;
                _defaultAgentUnavailableCodeOnConsecutiveBounces = value;
            }
        }

        [XmlIgnore]
        public bool DefaultAgentUnavailableCodeOnConsecutiveBouncesSpecified { get; set; }

        private bool _forceUseOfAgentUnavailableCodes;

        [XmlElement(ElementName = "forceUseOfAgentUnavailableCodes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24147")]
        public bool ForceUseOfAgentUnavailableCodes
        {
            get => _forceUseOfAgentUnavailableCodes;
            set
            {
                ForceUseOfAgentUnavailableCodesSpecified = true;
                _forceUseOfAgentUnavailableCodes = value;
            }
        }

        [XmlIgnore]
        public bool ForceUseOfAgentUnavailableCodesSpecified { get; set; }

        private string _defaultAgentUnavailableCode;

        [XmlElement(ElementName = "defaultAgentUnavailableCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:24147")]
        [MinLength(1)]
        [MaxLength(10)]
        public string DefaultAgentUnavailableCode
        {
            get => _defaultAgentUnavailableCode;
            set
            {
                DefaultAgentUnavailableCodeSpecified = true;
                _defaultAgentUnavailableCode = value;
            }
        }

        [XmlIgnore]
        public bool DefaultAgentUnavailableCodeSpecified { get; set; }

    }
}
