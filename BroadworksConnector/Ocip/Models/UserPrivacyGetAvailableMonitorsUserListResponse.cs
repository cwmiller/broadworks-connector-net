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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b87b6355d5858fdbeb8c1eb05dc1651a:128""}]")]
    public class UserPrivacyGetAvailableMonitorsUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableMonitorsTable;

        [XmlElement(ElementName = "availableMonitorsTable", IsNullable = false, Namespace = "")]
        [Group(@"b87b6355d5858fdbeb8c1eb05dc1651a:128")]
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
