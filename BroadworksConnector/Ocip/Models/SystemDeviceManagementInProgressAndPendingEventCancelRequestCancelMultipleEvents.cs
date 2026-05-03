using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8041""}]")]
    public class SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusForCancel? _dmEventStatusForCancel;

        [XmlElement(ElementName = "dmEventStatusForCancel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8041")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusForCancel? DmEventStatusForCancel
        {
            get => _dmEventStatusForCancel;
            set
            {
                DmEventStatusForCancelSpecified = (value != null);
                _dmEventStatusForCancel = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventStatusForCancelSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventAction? _dmEventAction;

        [XmlElement(ElementName = "dmEventAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8041")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventAction? DmEventAction
        {
            get => _dmEventAction;
            set
            {
                DmEventActionSpecified = (value != null);
                _dmEventAction = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventActionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel? _dmEventLevel;

        [XmlElement(ElementName = "dmEventLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8041")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel? DmEventLevel
        {
            get => _dmEventLevel;
            set
            {
                DmEventLevelSpecified = (value != null);
                _dmEventLevel = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventLevelSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementEventType? _dmEventType;

        [XmlElement(ElementName = "dmEventType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8041")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventType? DmEventType
        {
            get => _dmEventType;
            set
            {
                DmEventTypeSpecified = (value != null);
                _dmEventType = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventTypeSpecified { get; set; }

    }
}
