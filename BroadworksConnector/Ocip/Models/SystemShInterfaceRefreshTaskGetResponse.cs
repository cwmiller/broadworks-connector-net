using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemShInterfaceRefreshTaskGetRequest.  Provides the status of the system refresh task.  If isRunning is false, numberPublicIdentityRefreshStarted and numberPublicIdentities are omitted.  If isRunning is true, numberPublicIdentities indicates the total number of public identities in the system that will be refreshed by the system refresh task; numberPublicIdentityRefreshesStarted indicates the total number of public identities for which a refresh has been started.
        /// <see cref="SystemShInterfaceRefreshTaskGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemShInterfaceRefreshTaskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isRunning;

        [XmlElement(ElementName = "isRunning", IsNullable = false, Namespace = "")]
        public bool IsRunning {
            get => _isRunning;
            set {
                IsRunningSpecified = true;
                _isRunning = value;
            }
        }

        [XmlIgnore]
        public bool IsRunningSpecified { get; set; }
        
        private int _numberPublicIdentityRefreshesStarted;

        [XmlElement(ElementName = "numberPublicIdentityRefreshesStarted", IsNullable = false, Namespace = "")]
        public int NumberPublicIdentityRefreshesStarted {
            get => _numberPublicIdentityRefreshesStarted;
            set {
                NumberPublicIdentityRefreshesStartedSpecified = true;
                _numberPublicIdentityRefreshesStarted = value;
            }
        }

        [XmlIgnore]
        public bool NumberPublicIdentityRefreshesStartedSpecified { get; set; }
        
        private int _numberPublicIdentities;

        [XmlElement(ElementName = "numberPublicIdentities", IsNullable = false, Namespace = "")]
        public int NumberPublicIdentities {
            get => _numberPublicIdentities;
            set {
                NumberPublicIdentitiesSpecified = true;
                _numberPublicIdentities = value;
            }
        }

        [XmlIgnore]
        public bool NumberPublicIdentitiesSpecified { get; set; }
        
    }
}
