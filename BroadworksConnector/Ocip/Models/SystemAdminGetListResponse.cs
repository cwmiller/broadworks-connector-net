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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2164""}]")]
    public class SystemAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _systemAdminTable;

        [XmlElement(ElementName = "systemAdminTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2164")]
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
        protected bool SystemAdminTableSpecified { get; set; }

    }
}
