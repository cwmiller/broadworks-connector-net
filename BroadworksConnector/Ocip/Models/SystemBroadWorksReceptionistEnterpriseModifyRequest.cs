using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify BroadWorks Receptionist - Enterprise settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb12998f4f9e45cedde01f08569f4c7c:81""}]")]
    public class SystemBroadWorksReceptionistEnterpriseModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private int _maxMonitoredUsers;

        [XmlElement(ElementName = "maxMonitoredUsers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:81")]
        [MinInclusive(1)]
        [MaxInclusive(1000)]
        public int MaxMonitoredUsers
        {
            get => _maxMonitoredUsers;
            set
            {
                MaxMonitoredUsersSpecified = true;
                _maxMonitoredUsers = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMonitoredUsersSpecified { get; set; }

    }
}
