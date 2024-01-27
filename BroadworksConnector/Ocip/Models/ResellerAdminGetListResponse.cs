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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:238""}]")]
    public class ResellerAdminGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _resellerAdminTable;

        [XmlElement(ElementName = "resellerAdminTable", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:238")]
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
