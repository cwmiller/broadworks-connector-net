using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify GETS system settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10994""}]")]
    public class SystemGETSModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

        protected bool _enableRequireResourcePriority;

        [XmlElement(ElementName = "enableRequireResourcePriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        public bool EnableRequireResourcePriority
        {
            get => _enableRequireResourcePriority;
            set
            {
                EnableRequireResourcePrioritySpecified = true;
                _enableRequireResourcePriority = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRequireResourcePrioritySpecified { get; set; }

        protected bool _sendAccessResourcePriority;

        [XmlElement(ElementName = "sendAccessResourcePriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        public bool SendAccessResourcePriority
        {
            get => _sendAccessResourcePriority;
            set
            {
                SendAccessResourcePrioritySpecified = true;
                _sendAccessResourcePriority = value;
            }
        }

        [XmlIgnore]
        protected bool SendAccessResourcePrioritySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GETSCallIdentifierMode _callIdentifierMode;

        [XmlElement(ElementName = "callIdentifierMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        public BroadWorksConnector.Ocip.Models.GETSCallIdentifierMode CallIdentifierMode
        {
            get => _callIdentifierMode;
            set
            {
                CallIdentifierModeSpecified = true;
                _callIdentifierMode = value;
            }
        }

        [XmlIgnore]
        protected bool CallIdentifierModeSpecified { get; set; }

        protected int _defaultPriorityAVP;

        [XmlElement(ElementName = "defaultPriorityAVP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        [MinInclusive(0)]
        [MaxInclusive(4)]
        public int DefaultPriorityAVP
        {
            get => _defaultPriorityAVP;
            set
            {
                DefaultPriorityAVPSpecified = true;
                _defaultPriorityAVP = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultPriorityAVPSpecified { get; set; }

        protected int _signalingDSCP;

        [XmlElement(ElementName = "signalingDSCP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        [MinInclusive(0)]
        [MaxInclusive(63)]
        public int SignalingDSCP
        {
            get => _signalingDSCP;
            set
            {
                SignalingDSCPSpecified = true;
                _signalingDSCP = value;
            }
        }

        [XmlIgnore]
        protected bool SignalingDSCPSpecified { get; set; }

        protected string _defaultRValue;

        [XmlElement(ElementName = "defaultRValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        [MinLength(3)]
        [MaxLength(80)]
        public string DefaultRValue
        {
            get => _defaultRValue;
            set
            {
                DefaultRValueSpecified = true;
                _defaultRValue = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultRValueSpecified { get; set; }

        protected bool _bypassRoRelease;

        [XmlElement(ElementName = "bypassRoRelease", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        public bool BypassRoRelease
        {
            get => _bypassRoRelease;
            set
            {
                BypassRoReleaseSpecified = true;
                _bypassRoRelease = value;
            }
        }

        [XmlIgnore]
        protected bool BypassRoReleaseSpecified { get; set; }

        protected bool _ignoreResourcePrioritiesWhenGETSDisabled;

        [XmlElement(ElementName = "ignoreResourcePrioritiesWhenGETSDisabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:10994")]
        public bool IgnoreResourcePrioritiesWhenGETSDisabled
        {
            get => _ignoreResourcePrioritiesWhenGETSDisabled;
            set
            {
                IgnoreResourcePrioritiesWhenGETSDisabledSpecified = true;
                _ignoreResourcePrioritiesWhenGETSDisabled = value;
            }
        }

        [XmlIgnore]
        protected bool IgnoreResourcePrioritiesWhenGETSDisabledSpecified { get; set; }

    }
}
