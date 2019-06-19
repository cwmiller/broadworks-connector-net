using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAdminGetListRequest.
    /// Contains a 6 column table with column headings "Administrator ID",
    /// "Last Name", "First Name", "Type", "Read Only", "Language".
    /// <see cref="SystemAdminGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1680""}]")]
    public class SystemAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _systemAdminTable;

        [XmlElement(ElementName = "systemAdminTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1680")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SystemAdminTable
        {
            get => _systemAdminTable;
            set
            {
                SystemAdminTableSpecified = true;
                _systemAdminTable = value;
            }
        }

        [XmlIgnore]
        public bool SystemAdminTableSpecified { get; set; }

    }
}
