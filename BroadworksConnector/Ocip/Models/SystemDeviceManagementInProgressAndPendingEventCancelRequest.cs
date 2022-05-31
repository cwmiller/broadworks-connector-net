using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Cancel pending and in progress events.  Either all events, multiple
    /// events, or a list of specified events can be canceled.
    /// When specifying multiple events, an event must meet all specified
    /// criteria to be canceled.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7865"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:7866""}]}]")]
    public class SystemDeviceManagementInProgressAndPendingEventCancelRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _cancelAllEvents;

        [XmlElement(ElementName = "cancelAllEvents", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7866")]
        public string CancelAllEvents
        {
            get => _cancelAllEvents;
            set
            {
                CancelAllEventsSpecified = true;
                _cancelAllEvents = value;
            }
        }

        [XmlIgnore]
        protected bool CancelAllEventsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents _cancelMultipleEvents;

        [XmlElement(ElementName = "cancelMultipleEvents", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7866")]
        public BroadWorksConnector.Ocip.Models.SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents CancelMultipleEvents
        {
            get => _cancelMultipleEvents;
            set
            {
                CancelMultipleEventsSpecified = true;
                _cancelMultipleEvents = value;
            }
        }

        [XmlIgnore]
        protected bool CancelMultipleEventsSpecified { get; set; }

        protected List<int> _eventId = new List<int>();

        [XmlElement(ElementName = "eventId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:7866")]
        public List<int> EventId
        {
            get => _eventId;
            set
            {
                EventIdSpecified = true;
                _eventId = value;
            }
        }

        [XmlIgnore]
        protected bool EventIdSpecified { get; set; }

    }
}
