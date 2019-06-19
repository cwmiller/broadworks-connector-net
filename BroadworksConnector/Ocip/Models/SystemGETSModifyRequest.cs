using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify GETS system settings.
    /// The following elements are only used in AS data mode and ignored in the Amplify data mode:
    /// callIdentifierMode
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9833""}]")]
    public class SystemGETSModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool EnabledSpecified { get; set; }

        private bool _enableRequireResourcePriority;

        [XmlElement(ElementName = "enableRequireResourcePriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool EnableRequireResourcePrioritySpecified { get; set; }

        private bool _sendAccessResourcePriority;

        [XmlElement(ElementName = "sendAccessResourcePriority", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool SendAccessResourcePrioritySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GETSCallIdentifierMode _callIdentifierMode;

        [XmlElement(ElementName = "callIdentifierMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool CallIdentifierModeSpecified { get; set; }

        private int _defaultPriorityAVP;

        [XmlElement(ElementName = "defaultPriorityAVP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool DefaultPriorityAVPSpecified { get; set; }

        private int _signalingDSCP;

        [XmlElement(ElementName = "signalingDSCP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool SignalingDSCPSpecified { get; set; }

        private string _defaultRValue;

        [XmlElement(ElementName = "defaultRValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool DefaultRValueSpecified { get; set; }

        private bool _bypassRoRelease;

        [XmlElement(ElementName = "bypassRoRelease", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9833")]
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
        public bool BypassRoReleaseSpecified { get; set; }

    }
}
