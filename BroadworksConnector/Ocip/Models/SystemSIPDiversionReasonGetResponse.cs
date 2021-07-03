using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDiversionReasonGetRequest.
    /// Contains a table containing a list of diversion reasons and associated cause values.
    /// The column headings are: "Diversion Reaon", "Cause Value".
    /// <see cref="SystemSIPDiversionReasonGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17493""}]")]
    public class SystemSIPDiversionReasonGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _diversionReasonTable;

        [XmlElement(ElementName = "diversionReasonTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17493")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DiversionReasonTable
        {
            get => _diversionReasonTable;
            set
            {
                DiversionReasonTableSpecified = true;
                _diversionReasonTable = value;
            }
        }

        [XmlIgnore]
        protected bool DiversionReasonTableSpecified { get; set; }

    }
}
