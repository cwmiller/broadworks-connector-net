using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserServiceGetAssignmentListRequest.
    /// Contains two tables, one for the service packs, and one for the user services.
    /// The user table has the column headings: "Service Name", "Assigned",
    /// The service pack table's column headings are: "Service Pack Name", "Assigned", "Description".
    /// The "Assigned" column has either a true or false value
    /// <see cref="UserServiceGetAssignmentListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:3893""}]")]
    public class UserServiceGetAssignmentListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _servicePacksAssignmentTable;

        [XmlElement(ElementName = "servicePacksAssignmentTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3893")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServicePacksAssignmentTable
        {
            get => _servicePacksAssignmentTable;
            set
            {
                ServicePacksAssignmentTableSpecified = true;
                _servicePacksAssignmentTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePacksAssignmentTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userServicesAssignmentTable;

        [XmlElement(ElementName = "userServicesAssignmentTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:3893")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserServicesAssignmentTable
        {
            get => _userServicesAssignmentTable;
            set
            {
                UserServicesAssignmentTableSpecified = true;
                _userServicesAssignmentTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserServicesAssignmentTableSpecified { get; set; }

    }
}
