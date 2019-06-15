using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system call admission control parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// enableRuntimeDataSync,
    /// runtimeIntervalInMilliSeconds
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRuntimeDataPublicationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private bool _enableRuntimeDataSync;

        [XmlElement(ElementName = "enableRuntimeDataSync", IsNullable = false, Namespace = "")]
        public bool EnableRuntimeDataSync {
            get => _enableRuntimeDataSync;
            set {
                EnableRuntimeDataSyncSpecified = true;
                _enableRuntimeDataSync = value;
            }
        }

        [XmlIgnore]
        public bool EnableRuntimeDataSyncSpecified { get; set; }
        
        private int _runtimeDataSyncIntervalInMilliSeconds;

        [XmlElement(ElementName = "runtimeDataSyncIntervalInMilliSeconds", IsNullable = false, Namespace = "")]
        public int RuntimeDataSyncIntervalInMilliSeconds {
            get => _runtimeDataSyncIntervalInMilliSeconds;
            set {
                RuntimeDataSyncIntervalInMilliSecondsSpecified = true;
                _runtimeDataSyncIntervalInMilliSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RuntimeDataSyncIntervalInMilliSecondsSpecified { get; set; }
        
    }
}
