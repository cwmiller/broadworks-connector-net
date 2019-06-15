using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for services that are active or not.
    /// This search criteria data type is only intended to be used by the commands
    /// introduced by BW-2301.
    /// The commands are EnterpriseUserCallWaitingSettingsGetListRequest
    /// and GroupUserCallWaitingSettingsGetListRequest.
        /// <see cref="EnterpriseUserCallWaitingSettingsGetListRequest"/>
        /// <see cref="GroupUserCallWaitingSettingsGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaServiceStatus : BroadWorksConnector.Ocip.Models.SearchCriteria
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
        
    }
}
