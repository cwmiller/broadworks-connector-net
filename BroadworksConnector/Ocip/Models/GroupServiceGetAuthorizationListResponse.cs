using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupServiceGetAuthorizationListRequest.
    /// Contains three tables, one for the service packs, one for the group services, and one for
    /// the user services.
    /// The user table has the following column headings:
    /// "Service Name", "Authorized", "Assigned", "Limited", "Quantity", "Usage", "Licensed", "Allowed", "User Assignable", "Group Service Assignable".
    /// The group service table has the following column headings:
    /// "Service Name", "Authorized", "Assigned", "Limited", "Quantity", "Usage", "Licensed", "Allowed", "Instance Count".
    /// The service pack table's column headings are:
    /// "Service Pack Name", "Authorized", "Assigned", "Limited", "Allocated", "Allowed", "Usage", "Description".
    /// <see cref="GroupServiceGetAuthorizationListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:7765""}]")]
    public class GroupServiceGetAuthorizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _servicePacksAuthorizationTable;

        [XmlElement(ElementName = "servicePacksAuthorizationTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7765")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServicePacksAuthorizationTable
        {
            get => _servicePacksAuthorizationTable;
            set
            {
                ServicePacksAuthorizationTableSpecified = true;
                _servicePacksAuthorizationTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePacksAuthorizationTableSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _groupServicesAuthorizationTable;

        [XmlElement(ElementName = "groupServicesAuthorizationTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7765")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupServicesAuthorizationTable
        {
            get => _groupServicesAuthorizationTable;
            set
            {
                GroupServicesAuthorizationTableSpecified = true;
                _groupServicesAuthorizationTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServicesAuthorizationTableSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _userServicesAuthorizationTable;

        [XmlElement(ElementName = "userServicesAuthorizationTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:7765")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserServicesAuthorizationTable
        {
            get => _userServicesAuthorizationTable;
            set
            {
                UserServicesAuthorizationTableSpecified = true;
                _userServicesAuthorizationTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserServicesAuthorizationTableSpecified { get; set; }

    }
}
