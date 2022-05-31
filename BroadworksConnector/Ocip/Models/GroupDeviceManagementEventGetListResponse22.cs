using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDeviceManagementEventGetListRequest22.
    /// Contains a table with column headings: "Event Id", "Status", "Action",
    /// "Level", "Type", "Additional Info", "Is Local", "Completion %",
    /// "Pushed/ Same Hash/ Not Pushed", "Login Id", "Start Time",
    /// "Process Time", "Rx Time", "Total Time", "Request", "Priority".
    /// "Event Id" is a unique identifer for the event.
    /// "Status" can be: Pending, Queued, In Progress,
    /// Process On Other Host, Stale, Completed, Canceled.
    /// "Action" can be: Delete, Download, Rebuild, Reset, Upload.
    /// "Level" can be: Device, Device Type, Device Type Group, Group, User.
    /// "Type" can be: Automatic, Manual.
    /// "Additional Info" includes the affected device type, device or group.
    /// It depends on the level of the event:
    /// Device Profile: "Device Name" "Service Provider Id" "Group Id"
    /// Device Type: "Device Type Name"
    /// Device Type Service Provider: "Service Provider Id" "Device Type Name"
    /// Service Provider: "Service Provider Id"
    /// Device Type Group: "Service Provider Id" "Group Id" "Device Type Name"
    /// Group: "Service Provider Id" "Group Id"
    /// User: "User Id"
    /// "Is Local" is set to "yes" if the event is processed on the server
    /// who received the request, "no" otherwise meaning that the event is
    /// processed on another server.
    /// "Completion %" provides an estimate of the completion of the event.
    /// A percentage is given, the current number of completed expanded event,
    /// and the total number of expanded event.
    /// "Pushed/ Same Hash/ Not Pushed" gives the total number of files that
    /// were pushed, not pushed because of same hash, and not pushed when
    /// processing the event.
    /// "LoginId" is the user or admin id who triggered the event.
    /// "Start Time" is the date when the event's processing started.  The
    /// display shows the month, day, hours, minutes, and seconds (MM-dd hh:mm:ss).
    /// "Process Time" is the time taken to process the event in hours,
    /// minutes, seconds, and milliseconds (hhhh:mm:ss.SSS).
    /// "Rx Time" is the date when the event was received via OCI-P and
    /// stored in the system.  The display shows the month, day, hours,
    /// minutes, and seconds (MM-dd hh:mm:ss).
    /// "Total Time" is the total time the event was in the system, from the
    /// moment it was received and stored until its processing ended, in
    /// hours, minutes, seconds, and milliseconds (hhhh:mm:ss.SSS).
    /// "Request" is the name of the OCI-P request that triggered the event.
    /// "Priority" is the priority of the event.
    /// <see cref="GroupDeviceManagementEventGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4167""}]")]
    public class GroupDeviceManagementEventGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _eventTable;

        [XmlElement(ElementName = "eventTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4167")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EventTable
        {
            get => _eventTable;
            set
            {
                EventTableSpecified = true;
                _eventTable = value;
            }
        }

        [XmlIgnore]
        protected bool EventTableSpecified { get; set; }

    }
}
