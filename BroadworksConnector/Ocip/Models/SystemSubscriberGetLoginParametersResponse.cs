using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetLoginParametersRequest.
    /// <see cref="SystemSubscriberGetLoginParametersRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17051""}]")]
    public class SystemSubscriberGetLoginParametersResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17051")]
        [MinInclusive(1)]
        [MaxInclusive(1000)]
        public int MaxFailedLoginAttempts
        {
            get => _maxFailedLoginAttempts;
            set
            {
                MaxFailedLoginAttemptsSpecified = true;
                _maxFailedLoginAttempts = value;
            }
        }

        [XmlIgnore]
        public bool MaxFailedLoginAttemptsSpecified { get; set; }

        private int _minLoginIdLength;

        [XmlElement(ElementName = "minLoginIdLength", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17051")]
        [MinInclusive(2)]
        [MaxInclusive(80)]
        public int MinLoginIdLength
        {
            get => _minLoginIdLength;
            set
            {
                MinLoginIdLengthSpecified = true;
                _minLoginIdLength = value;
            }
        }

        [XmlIgnore]
        public bool MinLoginIdLengthSpecified { get; set; }

    }
}
