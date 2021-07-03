using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ResellerGetListRequest.
    /// Contains a 2 column table with column headings "Reseller Id", "Reseller Name" and "Reseller External Id". A row for each reseller.
    /// <see cref="ResellerGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:568""}]")]
    public class ResellerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _resellerTable;

        [XmlElement(ElementName = "resellerTable", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:568")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ResellerTable
        {
            get => _resellerTable;
            set
            {
                ResellerTableSpecified = true;
                _resellerTable = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerTableSpecified { get; set; }

    }
}
