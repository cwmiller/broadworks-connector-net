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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ee7bb69368e23a56a82c5d9cf07b5433:134""}]")]
    public class SystemSMDIMessageDeskGetServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _smdiServerTable;

        [XmlElement(ElementName = "smdiServerTable", IsNullable = false, Namespace = "")]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:134")]
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
