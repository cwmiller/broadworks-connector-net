using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupMusicOnHoldGetInstanceRequest22V3.
    /// Replaced by: GroupMusicOnHoldGetInstanceResponse23V2
    /// <see cref="GroupMusicOnHoldGetInstanceRequest22V3"/>
    /// <see cref="GroupMusicOnHoldGetInstanceResponse23V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:3790""}]")]
    public class GroupMusicOnHoldGetInstanceResponse22V3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

        protected bool _isActiveDuringCallHold;

        [XmlElement(ElementName = "isActiveDuringCallHold", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

        protected bool _isActiveDuringCallPark;

        [XmlElement(ElementName = "isActiveDuringCallPark", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

        protected bool _isActiveDuringBusyCampOn;

        [XmlElement(ElementName = "isActiveDuringBusyCampOn", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

        protected bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3 _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

        protected bool _useAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldSourceRead22V3 _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:3790")]
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

    }
}
