using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBroadWorksReceptionistOfficeGetRequest.
    /// Returns a 11 column table with column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Group Id", "Phone Number", "Extension", "Mobile", "Email Address", "Department", "IMP Id", "Title".
    /// <see cref="UserBroadWorksReceptionistOfficeGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4085b673b5035cde8e8ce380d60d6aed:103""}]")]
    public class UserBroadWorksReceptionistOfficeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

        [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
        [Group(@"4085b673b5035cde8e8ce380d60d6aed:103")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MonitoredUserTable
        {
            get => _monitoredUserTable;
            set
            {
                MonitoredUserTableSpecified = true;
                _monitoredUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool MonitoredUserTableSpecified { get; set; }

    }
}
