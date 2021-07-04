using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupMusicOnHoldGetInstanceRequest23V2.
    /// The following elements are only used in AS data mode:
    /// - useDynamicMOHDuringCallHold, value “false” is returned in XS data mode.
    /// <see cref="GroupMusicOnHoldGetInstanceRequest23V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""66fe518a637c74cc4b2c97aa7f68fc49:150""}]")]
    public class GroupMusicOnHoldGetInstanceResponse23V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
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
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
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
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
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
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
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
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3 _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3 Source
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
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3 _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3 InternalSource
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

        private bool _useDynamicMOHDuringCallHold;

        [XmlElement(ElementName = "useDynamicMOHDuringCallHold", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:150")]
        public bool UseDynamicMOHDuringCallHold
        {
            get => _useDynamicMOHDuringCallHold;
            set
            {
                UseDynamicMOHDuringCallHoldSpecified = true;
                _useDynamicMOHDuringCallHold = value;
            }
        }

        [XmlIgnore]
        protected bool UseDynamicMOHDuringCallHoldSpecified { get; set; }

    }
}
