using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's Communication Barring User-Control settings.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringUserControlModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _enableLockout;

        [XmlElement(ElementName = "enableLockout", IsNullable = false, Namespace = "")]
        public bool EnableLockout {
            get => _enableLockout;
            set {
                EnableLockoutSpecified = true;
                _enableLockout = value;
            }
        }

        [XmlIgnore]
        public bool EnableLockoutSpecified { get; set; }
        
        private int _maxNumberOfFailedAttempts;

        [XmlElement(ElementName = "maxNumberOfFailedAttempts", IsNullable = false, Namespace = "")]
        public int MaxNumberOfFailedAttempts {
            get => _maxNumberOfFailedAttempts;
            set {
                MaxNumberOfFailedAttemptsSpecified = true;
                _maxNumberOfFailedAttempts = value;
            }
        }

        [XmlIgnore]
        public bool MaxNumberOfFailedAttemptsSpecified { get; set; }
        
        private int _lockoutMinutes;

        [XmlElement(ElementName = "lockoutMinutes", IsNullable = false, Namespace = "")]
        public int LockoutMinutes {
            get => _lockoutMinutes;
            set {
                LockoutMinutesSpecified = true;
                _lockoutMinutes = value;
            }
        }

        [XmlIgnore]
        public bool LockoutMinutesSpecified { get; set; }
        
    }
}
