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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11223""}]")]
    public class SystemGETSResourcePriorityGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _resourcePriorityTable;

        [XmlElement(ElementName = "resourcePriorityTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11223")]
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
        protected bool ResourcePriorityTableSpecified { get; set; }

    }
}
