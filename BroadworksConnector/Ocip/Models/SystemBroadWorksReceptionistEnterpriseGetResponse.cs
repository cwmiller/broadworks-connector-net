using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBroadWorksReceptionistEnterpriseGetRequest.
    /// Contains a list of BroadWorks Receptionist - Enterprise parameters.
    /// <see cref="SystemBroadWorksReceptionistEnterpriseGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb12998f4f9e45cedde01f08569f4c7c:65""}]")]
    public class SystemBroadWorksReceptionistEnterpriseGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _maxMonitoredUsers;

        [XmlElement(ElementName = "maxMonitoredUsers", IsNullable = false, Namespace = "")]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:65")]
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
