using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with network progression.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemNetworkProgressionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private int _waitPeriodSeconds;

        [XmlElement(ElementName = "waitPeriodSeconds", IsNullable = false, Namespace = "")]
        public int WaitPeriodSeconds {
            get => _waitPeriodSeconds;
            set {
                WaitPeriodSecondsSpecified = true;
                _waitPeriodSeconds = value;
            }
        }

        [XmlIgnore]
        public bool WaitPeriodSecondsSpecified { get; set; }
        
    }
}
