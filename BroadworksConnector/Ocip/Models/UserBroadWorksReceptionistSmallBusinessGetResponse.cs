using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBroadWorksReceptionistSmallBusinessGetRequest.
    /// Returns a 12 column table with column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Group Id", "Phone Number", "Extension", "Mobile", "Email Address", "Department", "IMP Id", "Title".
    /// <see cref="UserBroadWorksReceptionistSmallBusinessGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c9d445cc2023c0bbcc8118fdbfdbb447:106""}]")]
    public class UserBroadWorksReceptionistSmallBusinessGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

        [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
        [Group(@"c9d445cc2023c0bbcc8118fdbfdbb447:106")]
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
