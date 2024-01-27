using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the
    /// SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest.
    /// The response contains a table of all Network Classes of Service that
    /// contain the specific CAllP Policy Profile. The column headings
    /// are "Name" and "Description".
    /// <see cref="SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:4012""}]")]
    public class SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _networkClassOfServiceTable;

        [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:4012")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable
        {
            get => _networkClassOfServiceTable;
            set
            {
                NetworkClassOfServiceTableSpecified = true;
                _networkClassOfServiceTable = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceTableSpecified { get; set; }

    }
}
