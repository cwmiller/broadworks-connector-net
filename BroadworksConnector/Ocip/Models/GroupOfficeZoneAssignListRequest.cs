using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Assign a list of Office Zones to a group.
    /// The Element defaultOfficeZone is required only for the first assignment, for subsequent assignments it is optional.
    /// Office Zones can only be assigned if the Location-Based Calling Restrictions has been authorized to the group otherwise the request will fail.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5656""}]")]
    public class GroupOfficeZoneAssignListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5656")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5656")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private List<string> _officeZoneName = new List<string>();

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5656")]
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
        public bool OfficeZoneNameSpecified { get; set; }

        private string _defaultOfficeZoneName;

        [XmlElement(ElementName = "defaultOfficeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5656")]
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
        public bool DefaultOfficeZoneNameSpecified { get; set; }

    }
}
