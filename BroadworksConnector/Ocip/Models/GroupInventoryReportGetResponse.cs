using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupInventoryReportGetRequest.
    /// <see cref="GroupInventoryReportGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5c0fc3a03773b4f430e938115770c82d:64""}]")]
    public class GroupInventoryReportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _inventoryReportTable;

        [XmlElement(ElementName = "inventoryReportTable", IsNullable = false, Namespace = "")]
        [Group(@"5c0fc3a03773b4f430e938115770c82d:64")]
        public BroadWorksConnector.Ocip.Models.C.OCITable InventoryReportTable
        {
            get => _inventoryReportTable;
            set
            {
                InventoryReportTableSpecified = true;
                _inventoryReportTable = value;
            }
        }

        [XmlIgnore]
        protected bool InventoryReportTableSpecified { get; set; }

    }
}
