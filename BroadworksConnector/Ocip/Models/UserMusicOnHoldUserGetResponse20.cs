using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMusicOnHoldUserGetRequest20.
    /// <see cref="UserMusicOnHoldUserGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""66fe518a637c74cc4b2c97aa7f68fc49:309""}]")]
    public class UserMusicOnHoldUserGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:309")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead20 _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:309")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead20 Source
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
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:309")]
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

        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead20 _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:309")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead20 InternalSource
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
