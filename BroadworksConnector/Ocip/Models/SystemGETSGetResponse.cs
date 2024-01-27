using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSGetRequest.
    /// Replaced By: SystemGETSGetResponse22
    /// <see cref="SystemGETSGetRequest"/>
    /// <see cref="SystemGETSGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27555""}]")]
    public class SystemGETSGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:27555")]
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

    }
}
