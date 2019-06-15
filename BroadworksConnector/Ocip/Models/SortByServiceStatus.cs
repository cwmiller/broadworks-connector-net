using System;
using System.Xml.Serialization;
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
     
    public class SortByServiceStatus : BroadWorksConnector.Ocip.Models.SortCriteria
    {

        
    }
}
