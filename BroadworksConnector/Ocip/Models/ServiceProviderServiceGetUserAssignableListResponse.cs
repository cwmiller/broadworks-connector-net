using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderServiceGetUserAssignableListRequest.
    /// <see cref="ServiceProviderServiceGetUserAssignableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:6017""}]")]
    public class ServiceProviderServiceGetUserAssignableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.UserService> _serviceName = new List<BroadWorksConnector.Ocip.Models.UserService>();

        [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:6017")]
        public List<BroadWorksConnector.Ocip.Models.UserService> ServiceName
        {
            get => _serviceName;
            set
            {
                ServiceNameSpecified = true;
                _serviceName = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceNameSpecified { get; set; }

    }
}
