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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7169""}]")]
    public class SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents
    {

        private BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusForCancel _dmEventStatusForCancel;

        [XmlElement(ElementName = "dmEventStatusForCancel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7169")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusForCancel DmEventStatusForCancel
        {
            get => _dmEventStatusForCancel;
            set
            {
                DmEventStatusForCancelSpecified = true;
                _dmEventStatusForCancel = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventStatusForCancelSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementEventAction _dmEventAction;

        [XmlElement(ElementName = "dmEventAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7169")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventAction DmEventAction
        {
            get => _dmEventAction;
            set
            {
                DmEventActionSpecified = true;
                _dmEventAction = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventActionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel _dmEventLevel;

        [XmlElement(ElementName = "dmEventLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7169")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel DmEventLevel
        {
            get => _dmEventLevel;
            set
            {
                DmEventLevelSpecified = true;
                _dmEventLevel = value;
            }
        }

        [XmlIgnore]
        protected bool DmEventLevelSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementEventType _dmEventType;

        [XmlElement(ElementName = "dmEventType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7169")]
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
