using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemClassmarkGetUtilizationListRequest.
    /// Contains a table with the column headings: "User Id", "Group Id", "Service Provider Id",
    /// "Last Name", "First Name", and "Phone Number", "Extension", "Department", "Email Address".
    /// <see cref="SystemClassmarkGetUtilizationListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0d0e878cbc947aebb19ad489b2ffef11:138""}]")]
    public class SystemClassmarkGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _classmarkUserTable;

        [XmlElement(ElementName = "classmarkUserTable", IsNullable = false, Namespace = "")]
        [Group(@"0d0e878cbc947aebb19ad489b2ffef11:138")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ClassmarkUserTable
        {
            get => _classmarkUserTable;
            set
            {
                ClassmarkUserTableSpecified = true;
                _classmarkUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool ClassmarkUserTableSpecified { get; set; }

    }
}
