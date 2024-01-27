using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetServiceInstanceListInSystemRequest.
    /// Contains a table with column headings : "User Id", "Group Id", "Service Provider Id", "Service Type", "Name", "Phone Number",
    /// "Extension", "Reseller Id" in a row for each Service Instance. Possible values for Service Type column are ServiceType enums.
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// <see cref="UserGetServiceInstanceListInSystemRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2306""}]")]
    public class UserGetServiceInstanceListInSystemResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceInstanceTable;

        [XmlElement(ElementName = "serviceInstanceTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2306")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceInstanceTable
        {
            get => _serviceInstanceTable;
            set
            {
                ServiceInstanceTableSpecified = true;
                _serviceInstanceTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceTableSpecified { get; set; }

    }
}
