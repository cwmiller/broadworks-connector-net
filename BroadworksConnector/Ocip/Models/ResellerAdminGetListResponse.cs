using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerAdminGetListRequest.
    /// Contains a 4 column table with column headings "Administrator ID",
    /// "Last Name", "First Name", "Language".
    /// <see cref="ResellerAdminGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:239""}]")]
    public class ResellerAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _resellerAdminTable;

        [XmlElement(ElementName = "resellerAdminTable", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:239")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ResellerAdminTable
        {
            get => _resellerAdminTable;
            set
            {
                ResellerAdminTableSpecified = true;
                _resellerAdminTable = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerAdminTableSpecified { get; set; }

    }
}
