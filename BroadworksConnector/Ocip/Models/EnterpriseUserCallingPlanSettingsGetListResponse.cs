using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the EnterpriseUserCallingPlanSettingsGetListRequest.
    /// Contains a table with column headings: "Group Id", "User Id", "Last Name", "First
    /// Name", "Hiragana Last Name", and "Hiragana First Name", "Phone
    /// Number", "Extension", "Department", "In Trunk Group", "Email Address",
    /// "Use Custom Settings".
    /// "Use Custom Settings" is "true" or "false".
    /// "Phone Number" is presented in the E164 format.
    /// <see cref="EnterpriseUserCallingPlanSettingsGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:1213""}]")]
    public class EnterpriseUserCallingPlanSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _userCallingPlanTable;

        [XmlElement(ElementName = "userCallingPlanTable", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:1213")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserCallingPlanTable
        {
            get => _userCallingPlanTable;
            set
            {
                UserCallingPlanTableSpecified = true;
                _userCallingPlanTable = value;
            }
        }

        [XmlIgnore]
        public bool UserCallingPlanTableSpecified { get; set; }

    }
}
