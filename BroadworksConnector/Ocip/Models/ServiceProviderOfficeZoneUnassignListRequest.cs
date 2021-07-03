using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Unassign a list of OfficeZones from a service provider.  Note: a new default must be provided if unassigning the current default.
    /// Office Zones can only be unassigned if the Location-Based Calling Restrictions has been authorized to the service provider otherwise the request will fail.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5264""}]")]
    public class ServiceProviderOfficeZoneUnassignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5264")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private List<string> _officeZoneName = new List<string>();

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5264")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> OfficeZoneName
        {
            get => _officeZoneName;
            set
            {
                OfficeZoneNameSpecified = true;
                _officeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneNameSpecified { get; set; }

        private string _defaultOfficeZoneName;

        [XmlElement(ElementName = "defaultOfficeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5264")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DefaultOfficeZoneName
        {
            get => _defaultOfficeZoneName;
            set
            {
                DefaultOfficeZoneNameSpecified = true;
                _defaultOfficeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultOfficeZoneNameSpecified { get; set; }

    }
}
