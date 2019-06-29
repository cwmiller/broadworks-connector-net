using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemOfficeZoneGetListRequest.
    /// The response contains a table of all Office Zones
    /// in the system. The column headings are "Name" and "Description"
    /// <see cref="SystemOfficeZoneGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12855""}]")]
    public class SystemOfficeZoneGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _officeZoneTable;

        [XmlElement(ElementName = "officeZoneTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12855")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OfficeZoneTable
        {
            get => _officeZoneTable;
            set
            {
                OfficeZoneTableSpecified = true;
                _officeZoneTable = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneTableSpecified { get; set; }

    }
}
