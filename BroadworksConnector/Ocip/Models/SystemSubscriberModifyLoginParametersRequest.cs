using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system login configuration for all subscribers
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSubscriberModifyLoginParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
