using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified Device Management event in progress or pending status.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusInProgressOrPending _dmEventStatusInProgressOrPending;

        [XmlElement(ElementName = "dmEventStatusInProgressOrPending", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusInProgressOrPending DmEventStatusInProgressOrPending {
            get => _dmEventStatusInProgressOrPending;
            set {
                DmEventStatusInProgressOrPendingSpecified = true;
                _dmEventStatusInProgressOrPending = value;
            }
        }

        [XmlIgnore]
        public bool DmEventStatusInProgressOrPendingSpecified { get; set; }
        
    }
}
