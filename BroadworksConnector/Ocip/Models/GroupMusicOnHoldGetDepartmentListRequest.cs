using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Returns a list of all departments that have a Music On Hold instance. The response is either GroupMusicOnHoldGetDepartmentListResponse or ErrorResponse.
    /// It is possible to get the instances within a specified department.
    /// <see cref="GroupMusicOnHoldGetDepartmentListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""66fe518a637c74cc4b2c97aa7f68fc49:96""}]")]
    public class GroupMusicOnHoldGetDepartmentListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:96")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:96")]
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
        protected bool GroupIdSpecified { get; set; }

        private string _groupDepartmentName;

        [XmlElement(ElementName = "groupDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"66fe518a637c74cc4b2c97aa7f68fc49:96")]
        [MinLength(1)]
        [MaxLength(50)]
        public string GroupDepartmentName
        {
            get => _groupDepartmentName;
            set
            {
                GroupDepartmentNameSpecified = true;
                _groupDepartmentName = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentNameSpecified { get; set; }

    }
}
