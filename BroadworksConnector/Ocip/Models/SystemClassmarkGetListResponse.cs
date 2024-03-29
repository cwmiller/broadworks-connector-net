using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemClassmarkGetListRequest.
    /// Contains a table of with the column headings: "Class Mark", "Value" and "Web Display Key".
    /// <see cref="SystemClassmarkGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""bd23272215266344f26a1702c47ce590:95""}]")]
    public class SystemClassmarkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _classmarkTable;

        [XmlElement(ElementName = "classmarkTable", IsNullable = false, Namespace = "")]
        [Group(@"bd23272215266344f26a1702c47ce590:95")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ClassmarkTable
        {
            get => _classmarkTable;
            set
            {
                ClassmarkTableSpecified = true;
                _classmarkTable = value;
            }
        }

        [XmlIgnore]
        protected bool ClassmarkTableSpecified { get; set; }

    }
}
