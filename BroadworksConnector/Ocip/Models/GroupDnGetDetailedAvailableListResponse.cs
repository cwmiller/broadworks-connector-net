using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDnGetDetailedAvailableListRequest.
    /// The response contains a table with columns: "Phone Number", "Department".
    /// The "Phone Numbers" column contains a single DN.
    /// The "Department" column contains the department of the DN if the DN is part of the department.
    /// The "Activated" column indicates if the DN has been activated.
    /// Only has a value if the DN(s) is assigned to a user or if "Group
    /// Enable Activation Mode" is enabled.
    /// <see cref="GroupDnGetDetailedAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4396""}]")]
    public class GroupDnGetDetailedAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

        [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4396")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnTable
        {
            get => _dnTable;
            set
            {
                DnTableSpecified = true;
                _dnTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnTableSpecified { get; set; }

    }
}
