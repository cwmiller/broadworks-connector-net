using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserGetServiceInstanceListInServiceProviderRequest.
    /// Contains a table with column headings :  "User Id", "Group Id", "Service Type",
    /// "Name", "Phone Number", "Extension", "Department" in a row for each Service Instance.  Possible values for Service Type column are ServiceType enums.
    /// <see cref="UserGetServiceInstanceListInServiceProviderRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:2254""}]")]
    public class UserGetServiceInstanceListInServiceProviderResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _serviceInstanceTable;

        [XmlElement(ElementName = "serviceInstanceTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:2254")]
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
