using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksReceptionistEnterpriseGetRequest.
    /// Contains a list of BroadWorks Receptionist - Enterprise parameters.
        /// <see cref="SystemBroadWorksReceptionistEnterpriseGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBroadWorksReceptionistEnterpriseGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _maxMonitoredUsers;

        [XmlElement(ElementName = "maxMonitoredUsers", IsNullable = false, Namespace = "")]
        public int MaxMonitoredUsers {
            get => _maxMonitoredUsers;
            set {
                MaxMonitoredUsersSpecified = true;
                _maxMonitoredUsers = value;
            }
        }

        [XmlIgnore]
        public bool MaxMonitoredUsersSpecified { get; set; }
        
    }
}
