using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserMusicOnHoldUserGetRequest.
    /// Replaced By: UserMusicOnHoldUserGetResponse16
    /// <see cref="UserMusicOnHoldUserGetRequest"/>
    /// <see cref="UserMusicOnHoldUserGetResponse16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:46175""}]")]
    public class UserMusicOnHoldUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:46175")]
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

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead _source;

        [XmlElement(ElementName = "source", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:46175")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead Source
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
        [Group(@"d8f04177e438f303b41c211e518706bf:46175")]
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

        protected BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead _internalSource;

        [XmlElement(ElementName = "internalSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:46175")]
        public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceRead InternalSource
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
