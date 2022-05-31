using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserLinePortGetListRequest.
    /// Contains a table of line ports configured for a user
    /// The column headings are: "Line Port", "Line Port Type", "In Trunk Group",
    /// "Contact", "Contact2", "Contact3", "Contact4", "Contact5", " Authentication Mode ",
    /// and "Auto-Config Soft Client".
    /// <see cref="UserLinePortGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2480""}]")]
    public class UserLinePortGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _linePortTable;

        [XmlElement(ElementName = "linePortTable", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2480")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LinePortTable
        {
            get => _linePortTable;
            set
            {
                LinePortTableSpecified = true;
                _linePortTable = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortTableSpecified { get; set; }

    }
}
