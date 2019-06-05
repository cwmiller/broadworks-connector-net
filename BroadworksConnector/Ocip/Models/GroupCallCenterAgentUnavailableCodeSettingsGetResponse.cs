using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterAgentUnavailableCodeSettingsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private bool _enableAgentUnavailableCodes;

        [XmlElement(ElementName = "enableAgentUnavailableCodes", IsNullable = false, Namespace = "")]
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
