using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBroadWorksReceptionistEnterpriseGetRequest.
    /// Returns a 12 column table with column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Group Id", "Phone Number", "Extension", "Mobile", "Email Address", "Department", "IMP Id", "Title",
    /// "Receptionist Note".
    /// The Receptionist Note column is only populated, if the user sending the request is the owner
    /// of the Receptionist Note and a Note exists.
    /// <see cref="UserBroadWorksReceptionistEnterpriseGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb12998f4f9e45cedde01f08569f4c7c:200""}]")]
    public class UserBroadWorksReceptionistEnterpriseGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

        [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:200")]
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
