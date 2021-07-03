using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:2146""}]")]
    public class SearchCriteriaServiceStatus : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:2146")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

    }
}
