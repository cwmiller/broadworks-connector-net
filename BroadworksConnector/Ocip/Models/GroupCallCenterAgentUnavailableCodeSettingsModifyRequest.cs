using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterAgentUnavailableCodeSettingsModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
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

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnDND", IsNullable = true, Namespace = "")]
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

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnPersonalCalls", IsNullable = true, Namespace = "")]
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

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnConsecutiveBounces", IsNullable = true, Namespace = "")]
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
        private string _defaultAgentUnavailableCodeOnNotReachable;

        [XmlElement(ElementName = "defaultAgentUnavailableCodeOnNotReachable", IsNullable = true, Namespace = "")]
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
        public bool DefaultAgentUnavailableCodeOnNotReachableSpecified { get; set; }
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

        [XmlElement(ElementName = "defaultAgentUnavailableCode", IsNullable = true, Namespace = "")]
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
        private List<BroadworksConnector.Ocip.Models.CallCenterAgentUnavailableCodeStateModify> _codeStateList;

        [XmlElement(ElementName = "codeStateList", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.CallCenterAgentUnavailableCodeStateModify> CodeStateList
        {
            get => _codeStateList;
            set
            {
                CodeStateListSpecified = true;
                _codeStateList = value;
            }
        }

        [XmlIgnore]
        public bool CodeStateListSpecified { get; set; }
    }
}
