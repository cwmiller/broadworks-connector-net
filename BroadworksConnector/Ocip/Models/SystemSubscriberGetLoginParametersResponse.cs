using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemSubscriberGetLoginParametersRequest.
        /// <see cref="SystemSubscriberGetLoginParametersRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberGetLoginParametersResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _maxFailedLoginAttempts;

        [XmlElement(ElementName = "maxFailedLoginAttempts", IsNullable = false, Namespace = "")]
        public int MaxFailedLoginAttempts {
            get => _maxFailedLoginAttempts;
            set {
                MaxFailedLoginAttemptsSpecified = true;
                _maxFailedLoginAttempts = value;
            }
        }

        [XmlIgnore]
        public bool MaxFailedLoginAttemptsSpecified { get; set; }
        
        private int _minLoginIdLength;

        [XmlElement(ElementName = "minLoginIdLength", IsNullable = false, Namespace = "")]
        public int MinLoginIdLength {
            get => _minLoginIdLength;
            set {
                MinLoginIdLengthSpecified = true;
                _minLoginIdLength = value;
            }
        }

        [XmlIgnore]
        public bool MinLoginIdLengthSpecified { get; set; }
        
    }
}
