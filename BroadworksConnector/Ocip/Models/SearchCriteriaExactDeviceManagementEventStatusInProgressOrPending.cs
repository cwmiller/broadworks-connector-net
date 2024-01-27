using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified Device Management event in progress or pending status.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:913""}]")]
    public class SearchCriteriaExactDeviceManagementEventStatusInProgressOrPending : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusInProgressOrPending _dmEventStatusInProgressOrPending;

        [XmlElement(ElementName = "dmEventStatusInProgressOrPending", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:913")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusInProgressOrPending DmEventStatusInProgressOrPending
        {
            get => _dmEventStatusInProgressOrPending;
            set
            {
                DmEventStatusInProgressOrPendingSpecified = true;
                _dmEventStatusInProgressOrPending = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventStatusInProgressOrPendingSpecified { get; set; }

    }
}
