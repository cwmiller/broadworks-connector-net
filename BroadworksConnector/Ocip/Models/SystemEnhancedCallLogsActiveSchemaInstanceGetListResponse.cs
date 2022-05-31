using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnhancedCallLogsSchemaInstanceActualUsageGetListRequest.
    /// Contains a table with column headings: "Instance Name", "Active Users".
    /// <see cref="SystemEnhancedCallLogsSchemaInstanceActualUsageGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:221""}]")]
    public class SystemEnhancedCallLogsActiveSchemaInstanceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _schemaInstanceUsageTable;

        [XmlElement(ElementName = "schemaInstanceUsageTable", IsNullable = false, Namespace = "")]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:221")]
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
