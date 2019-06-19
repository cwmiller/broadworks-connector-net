using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSResourcePriorityGetListRequest.
    /// The table columns are: "Priority Value", "Priority Level" and "Priority Class".
    /// <see cref="SystemGETSResourcePriorityGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10061""}]")]
    public class SystemGETSResourcePriorityGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _resourcePriorityTable;

        [XmlElement(ElementName = "resourcePriorityTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10061")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ResourcePriorityTable
        {
            get => _resourcePriorityTable;
            set
            {
                ResourcePriorityTableSpecified = true;
                _resourcePriorityTable = value;
            }
        }

        [XmlIgnore]
        public bool ResourcePriorityTableSpecified { get; set; }

    }
}
