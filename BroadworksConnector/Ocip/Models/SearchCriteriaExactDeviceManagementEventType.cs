using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified DeviceManagement event type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""972fbf832439609ec8f2765c5637c3f1:928""}]")]
    public class SearchCriteriaExactDeviceManagementEventType : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventType _dmEventType;

        [XmlElement(ElementName = "dmEventType", IsNullable = false, Namespace = "")]
        [Group(@"972fbf832439609ec8f2765c5637c3f1:928")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventType DmEventType
        {
            get => _dmEventType;
            set
            {
                DmEventTypeSpecified = true;
                _dmEventType = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventTypeSpecified { get; set; }

    }
}
