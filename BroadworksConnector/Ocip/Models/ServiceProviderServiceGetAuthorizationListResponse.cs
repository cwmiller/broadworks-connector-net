using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServiceGetAuthorizationListRequest.
    /// Contains two tables, one for the group services and one for the user services.
    /// The Group Service table has column headings:
    /// "Service Name", "Authorized", "Assigned", "Limited", "Quantity", "Allocated", "Licensed", "Service Pack Allocation"
    /// The User Service table has column headings:
    /// "Service Name", "Authorized", "Assigned", "Limited", "Quantity", "Allocated", "Licensed", "Service Pack Allocation", "User Assignable", "Service Pack Assignable".
    /// <see cref="ServiceProviderServiceGetAuthorizationListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6006""}]")]
    public class ServiceProviderServiceGetAuthorizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupServicesAuthorizationTable;

        [XmlElement(ElementName = "groupServicesAuthorizationTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6006")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userServicesAuthorizationTable;

        [XmlElement(ElementName = "userServicesAuthorizationTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6006")]
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
