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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:2161""}]")]
    public class SearchCriteriaServiceStatus : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:2161")]
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
