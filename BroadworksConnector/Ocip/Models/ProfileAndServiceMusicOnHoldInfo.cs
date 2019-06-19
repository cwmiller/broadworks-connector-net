using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Music On Hold service
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4271""}]")]
    public class ProfileAndServiceMusicOnHoldInfo
    {

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4271")]
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
        public bool EnableVideoSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead16 _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4271")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead16 Source
        {
            get => _source;
            set
            {
                SourceSpecified = true;
                _source = value;
            }
        }

        [XmlIgnore]
        public bool SourceSpecified { get; set; }

        private bool _useAlternateSourceForInternalCalls;

        [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4271")]
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
        public bool UseAlternateSourceForInternalCallsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead16 _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4271")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead16 InternalSource
        {
            get => _internalSource;
            set
            {
                InternalSourceSpecified = true;
                _internalSource = value;
            }
        }

        [XmlIgnore]
        public bool InternalSourceSpecified { get; set; }

    }
}
