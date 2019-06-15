using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified DeviceManagement event type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactDeviceManagementEventType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private BroadWorksConnector.Ocip.Models.DeviceManagementEventType _dmEventType;

        [XmlElement(ElementName = "dmEventType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventType DmEventType {
            get => _dmEventType;
            set {
                DmEventTypeSpecified = true;
                _dmEventType = value;
            }
        }

        [XmlIgnore]
        public bool DmEventTypeSpecified { get; set; }
        
    }
}
