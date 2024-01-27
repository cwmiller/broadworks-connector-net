using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPrivacyGetAvailableMonitorsUserListRequest.
    /// Returns a 10 column table with column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name",
    /// "Hiragana First Name", "Phone Number", "Extension", "Department", "Email Address", "IMP Id".
    /// <see cref="UserPrivacyGetAvailableMonitorsUserListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0850ccc76fd27f9c07cb7218b2c1f84:127""}]")]
    public class UserPrivacyGetAvailableMonitorsUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableMonitorsTable;

        [XmlElement(ElementName = "availableMonitorsTable", IsNullable = false, Namespace = "")]
        [Group(@"f0850ccc76fd27f9c07cb7218b2c1f84:127")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableMonitorsTable
        {
            get => _availableMonitorsTable;
            set
            {
                AvailableMonitorsTableSpecified = true;
                _availableMonitorsTable = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableMonitorsTableSpecified { get; set; }

    }
}
