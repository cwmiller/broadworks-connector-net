using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserRoutePointSupervisorGetListRequest.
    /// Contains a table with column headings: "User Id", "Last Name",
    /// "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address",
    /// "Location Code".
    /// <see cref="UserRoutePointSupervisorGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:1316""}]")]
    public class UserRoutePointSupervisorGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _supervisorTable;

        [XmlElement(ElementName = "supervisorTable", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1316")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SupervisorTable
        {
            get => _supervisorTable;
            set
            {
                SupervisorTableSpecified = true;
                _supervisorTable = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorTableSpecified { get; set; }

    }
}
