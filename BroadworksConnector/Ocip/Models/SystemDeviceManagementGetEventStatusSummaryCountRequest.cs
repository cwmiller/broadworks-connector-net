using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a summary table of the number of events in state 'Pending',
    /// 'Queued Internally', and 'Completed' in the system per action.
    /// One row is returned per action.
    /// Actions are as per the DeviceManagementEventActionType (ex: Delete, Download, Rebuild, Reset, Upload).
    /// The state 'Queued Internally' includes total for events with status
    /// equal to 'Queued' and 'In Progress' as per DeviceManagementEventStatus.
    /// The response is either SystemDeviceManagementGetEventStatusSummaryCountResponse or ErrorResponse.
    /// <see cref="SystemDeviceManagementGetEventStatusSummaryCountResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7951""}]")]
    public class SystemDeviceManagementGetEventStatusSummaryCountRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceManagementGetEventStatusSummaryCountResponse>
    {

    }
}
