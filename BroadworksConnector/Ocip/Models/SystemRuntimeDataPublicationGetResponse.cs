using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRuntimeDataPublicationGetRequest.
    /// The response contains the system call admission control parameters information.
    /// The following elements are only used in AS data mode:
    /// enableRuntimeDataSync, value "false" is returned in XS data mode.
    /// runtimeDataSyncIntervalInMilliSeconds value "1000" is returned in XS data mode.
        /// <see cref="SystemRuntimeDataPublicationGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRuntimeDataPublicationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
