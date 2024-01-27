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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18254""}]")]
    public class SystemSubscriberGetLoginParametersResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18254")]
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
        protected bool MaxFailedLoginAttemptsSpecified { get; set; }

        protected int _minLoginIdLength;

        [XmlElement(ElementName = "minLoginIdLength", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18254")]
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
        protected bool MinLoginIdLengthSpecified { get; set; }

    }
}
