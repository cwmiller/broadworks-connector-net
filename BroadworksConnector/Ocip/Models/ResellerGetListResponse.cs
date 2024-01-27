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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:570""}]")]
    public class ResellerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _resellerTable;

        [XmlElement(ElementName = "resellerTable", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:570")]
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
