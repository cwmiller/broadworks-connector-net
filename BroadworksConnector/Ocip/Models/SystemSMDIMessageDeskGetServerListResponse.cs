using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaServerGetListRequest. The SMDI Server table column
    /// headings are: "Device Name", "Net Address", "Port" and "Description".
    /// <see cref="SystemMediaServerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""aa3a240fa755015613cfb9259eccafef:134""}]")]
    public class SystemSMDIMessageDeskGetServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _smdiServerTable;

        [XmlElement(ElementName = "smdiServerTable", IsNullable = false, Namespace = "")]
        [Group(@"aa3a240fa755015613cfb9259eccafef:134")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SmdiServerTable
        {
            get => _smdiServerTable;
            set
            {
                SmdiServerTableSpecified = true;
                _smdiServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool SmdiServerTableSpecified { get; set; }

    }
}
