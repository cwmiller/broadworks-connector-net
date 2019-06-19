using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The sort criteria specifies the service status as the column for
    /// the sort, whether the sort is ascending or descending, and whether the
    /// sort is case sensitive.
    /// This sort criteria data type is only intended to be used by the commands
    /// introduced by BW-2301.
    /// The commands are EnterpriseUserCallWaitingSettingsGetListRequest, GroupUserCallWaitingSettingsGetListRequest,
    /// EnterpriseUserHotelingGuestSettingsGetListRequest, and GroupUserHotelingGuestSettingsGetListRequest.
    /// <see cref="EnterpriseUserCallWaitingSettingsGetListRequest"/>
    /// <see cref="GroupUserCallWaitingSettingsGetListRequest"/>
    /// <see cref="EnterpriseUserHotelingGuestSettingsGetListRequest"/>
    /// <see cref="GroupUserHotelingGuestSettingsGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""58293b6da8bb02a6430b3eb1beb91194:610""}]")]
    public class SortByServiceStatus : BroadWorksConnector.Ocip.Models.SortCriteria
    {

    }
}
