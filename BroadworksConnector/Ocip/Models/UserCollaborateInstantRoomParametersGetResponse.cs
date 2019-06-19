using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCollaborateInstantRoomParametersGetRequest.
    /// <see cref="UserCollaborateInstantRoomParametersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""939fd5846dfae8bdf58308d6cb9ebb12:718""}]")]
    public class UserCollaborateInstantRoomParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.CollaborateRoomAttendeeNotification _attendeeNotification;

        [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:718")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomAttendeeNotification AttendeeNotification
        {
            get => _attendeeNotification;
            set
            {
                AttendeeNotificationSpecified = true;
                _attendeeNotification = value;
            }
        }

        [XmlIgnore]
        public bool AttendeeNotificationSpecified { get; set; }

        private bool _endCollaborateRoomSessionOnOwnerExit;

        [XmlElement(ElementName = "endCollaborateRoomSessionOnOwnerExit", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:718")]
        public bool EndCollaborateRoomSessionOnOwnerExit
        {
            get => _endCollaborateRoomSessionOnOwnerExit;
            set
            {
                EndCollaborateRoomSessionOnOwnerExitSpecified = true;
                _endCollaborateRoomSessionOnOwnerExit = value;
            }
        }

        [XmlIgnore]
        public bool EndCollaborateRoomSessionOnOwnerExitSpecified { get; set; }

        private bool _ownerRequired;

        [XmlElement(ElementName = "ownerRequired", IsNullable = false, Namespace = "")]
        [Group(@"939fd5846dfae8bdf58308d6cb9ebb12:718")]
        public bool OwnerRequired
        {
            get => _ownerRequired;
            set
            {
                OwnerRequiredSpecified = true;
                _ownerRequired = value;
            }
        }

        [XmlIgnore]
        public bool OwnerRequiredSpecified { get; set; }

    }
}
