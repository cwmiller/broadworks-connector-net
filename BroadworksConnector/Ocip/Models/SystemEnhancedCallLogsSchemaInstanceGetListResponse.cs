using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnhancedCallLogsSchemaInstanceGetListRequest.
    /// Contains a table with column headings: "Instance Name", "Actual Users", "Potential Users".
    /// <see cref="SystemEnhancedCallLogsSchemaInstanceGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:263""}]")]
    public class SystemEnhancedCallLogsSchemaInstanceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _schemaInstanceUsageTable;

        [XmlElement(ElementName = "schemaInstanceUsageTable", IsNullable = false, Namespace = "")]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:263")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SchemaInstanceUsageTable
        {
            get => _schemaInstanceUsageTable;
            set
            {
                SchemaInstanceUsageTableSpecified = true;
                _schemaInstanceUsageTable = value;
            }
        }

        [XmlIgnore]
        protected bool SchemaInstanceUsageTableSpecified { get; set; }

    }
}
