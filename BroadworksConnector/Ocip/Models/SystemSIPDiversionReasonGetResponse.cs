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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17720""}]")]
    public class SystemSIPDiversionReasonGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _diversionReasonTable;

        [XmlElement(ElementName = "diversionReasonTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17720")]
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
