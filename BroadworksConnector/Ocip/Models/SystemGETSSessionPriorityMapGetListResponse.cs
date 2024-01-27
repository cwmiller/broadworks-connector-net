using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSSessionPriorityMapGetListRequest.
    /// The table columns are: "Priority Level" and "Session Priority Value".
    /// <see cref="SystemGETSSessionPriorityMapGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11303""}]")]
    public class SystemGETSSessionPriorityMapGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _sessionPriorityTable;

        [XmlElement(ElementName = "sessionPriorityTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11303")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SessionPriorityTable
        {
            get => _sessionPriorityTable;
            set
            {
                SessionPriorityTableSpecified = true;
                _sessionPriorityTable = value;
            }
        }

        [XmlIgnore]
        protected bool SessionPriorityTableSpecified { get; set; }

    }
}
