using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAdviceOfChargeCostInformationSourceGetListRequest.
    /// Contains a table with column headings: "PeerIdentity", "Priority"
    /// <see cref="SystemAdviceOfChargeCostInformationSourceGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a69fde15f3aa7494d83b57461a7a70bb:201""}]")]
    public class SystemAdviceOfChargeCostInformationSourceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _costInformationSourceTable;

        [XmlElement(ElementName = "costInformationSourceTable", IsNullable = false, Namespace = "")]
        [Group(@"a69fde15f3aa7494d83b57461a7a70bb:201")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CostInformationSourceTable
        {
            get => _costInformationSourceTable;
            set
            {
                CostInformationSourceTableSpecified = true;
                _costInformationSourceTable = value;
            }
        }

        [XmlIgnore]
        protected bool CostInformationSourceTableSpecified { get; set; }

    }
}
