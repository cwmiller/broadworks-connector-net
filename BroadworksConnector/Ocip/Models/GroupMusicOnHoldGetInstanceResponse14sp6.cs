using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupMusicOnHoldGetInstanceRequest14sp6.
    /// Replaced By: GroupMusicOnHoldGetInstanceResponse16
    /// <see cref="GroupMusicOnHoldGetInstanceRequest14sp6"/>
    /// <see cref="GroupMusicOnHoldGetInstanceResponse16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:11379""}]")]
    public class GroupMusicOnHoldGetInstanceResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        private bool _isActiveDuringCallHold;

        [XmlElement(ElementName = "isActiveDuringCallHold", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        public bool IsActiveDuringCallHold
        {
            get => _isActiveDuringCallHold;
            set
            {
                IsActiveDuringCallHoldSpecified = true;
                _isActiveDuringCallHold = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveDuringCallHoldSpecified { get; set; }

        private bool _isActiveDuringCallPark;

        [XmlElement(ElementName = "isActiveDuringCallPark", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        public bool IsActiveDuringCallPark
        {
            get => _isActiveDuringCallPark;
            set
            {
                IsActiveDuringCallParkSpecified = true;
                _isActiveDuringCallPark = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveDuringCallParkSpecified { get; set; }

        private bool _isActiveDuringBusyCampOn;

        [XmlElement(ElementName = "isActiveDuringBusyCampOn", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        public bool IsActiveDuringBusyCampOn
        {
            get => _isActiveDuringBusyCampOn;
            set
            {
                IsActiveDuringBusyCampOnSpecified = true;
                _isActiveDuringBusyCampOn = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveDuringBusyCampOnSpecified { get; set; }

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        public bool EnableVideo
        {
            get => _enableVideo;
            set
            {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVideoSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead Source
        {
            get => _source;
            set
            {
                SourceSpecified = true;
                _source = value;
            }
        }

        [XmlIgnore]
        protected bool SourceSpecified { get; set; }

        private bool _useAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        public bool UseAlternateSourceForInternalCalls
        {
            get => _useAlternateSourceForInternalCalls;
            set
            {
                UseAlternateSourceForInternalCallsSpecified = true;
                _useAlternateSourceForInternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseAlternateSourceForInternalCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11379")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead InternalSource
        {
            get => _internalSource;
            set
            {
                InternalSourceSpecified = true;
                _internalSource = value;
            }
        }

        [XmlIgnore]
        protected bool InternalSourceSpecified { get; set; }

    }
}
