using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4.
    /// <see cref="GroupCallCenterAgentUnavailableCodeSettingsGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:2673""}]")]
    public class GroupCallCenterAgentUnavailableCodeSettingsGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableAgentUnavailableCodes;

        [XmlElement(ElementName = "enableAgentUnavailableCodes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2673")]
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
        protected bool EnableAgentUnavailableCodesSpecified { get; set; }

        private string _defaultAgentUnavailableCodeOnDND;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnDND", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2673")]
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
        protected bool DefaultAgentUnavailableCodeOnDNDSpecified { get; set; }

        private string _defaultAgentUnavailableCodeOnPersonalCalls;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnPersonalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2673")]
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
        protected bool DefaultAgentUnavailableCodeOnPersonalCallsSpecified { get; set; }

        private string _defaultAgentUnavailableCodeOnConsecutiveBounces;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnConsecutiveBounces", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2673")]
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
        protected bool DefaultAgentUnavailableCodeOnConsecutiveBouncesSpecified { get; set; }

        private string _defaultAgentUnavailableCodeOnNotReachable;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnNotReachable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2673")]
        [MinLength(1)]
        [MaxLength(10)]
        public string DefaultAgentUnavailableCodeOnNotReachable
        {
            get => _defaultAgentUnavailableCodeOnNotReachable;
            set
            {
                DefaultAgentUnavailableCodeOnNotReachableSpecified = true;
                _defaultAgentUnavailableCodeOnNotReachable = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultAgentUnavailableCodeOnNotReachableSpecified { get; set; }

        private bool _forceUseOfAgentUnavailableCodes;

        [XmlElement(ElementName = "forceUseOfAgentUnavailableCodes", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2673")]
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
        protected bool ForceUseOfAgentUnavailableCodesSpecified { get; set; }

        private string _defaultAgentUnavailableCode;

        [XmlElement(ElementName = "defaultAgentUnavailableCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:2673")]
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
        protected bool DefaultAgentUnavailableCodeSpecified { get; set; }

    }
}
