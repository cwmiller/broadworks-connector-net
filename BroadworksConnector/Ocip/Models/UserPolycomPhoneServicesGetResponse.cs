using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserPolycomPhoneServicesGetRequest.
    /// <see cref="UserPolycomPhoneServicesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ff29a940e42c5c9737f7438c4e6eea9d:148""}]")]
    public class UserPolycomPhoneServicesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _integratePhoneDirectoryWithBroadWorks;

        [XmlElement(ElementName = "integratePhoneDirectoryWithBroadWorks", IsNullable = false, Namespace = "")]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:148")]
        public bool IntegratePhoneDirectoryWithBroadWorks
        {
            get => _integratePhoneDirectoryWithBroadWorks;
            set
            {
                IntegratePhoneDirectoryWithBroadWorksSpecified = true;
                _integratePhoneDirectoryWithBroadWorks = value;
            }
        }

        [XmlIgnore]
        protected bool IntegratePhoneDirectoryWithBroadWorksSpecified { get; set; }

        protected bool _includeUserPersonalPhoneListInDirectory;

        [XmlElement(ElementName = "includeUserPersonalPhoneListInDirectory", IsNullable = false, Namespace = "")]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:148")]
        public bool IncludeUserPersonalPhoneListInDirectory
        {
            get => _includeUserPersonalPhoneListInDirectory;
            set
            {
                IncludeUserPersonalPhoneListInDirectorySpecified = true;
                _includeUserPersonalPhoneListInDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeUserPersonalPhoneListInDirectorySpecified { get; set; }

        protected bool _includeGroupCustomContactDirectoryInDirectory;

        [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false, Namespace = "")]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:148")]
        public bool IncludeGroupCustomContactDirectoryInDirectory
        {
            get => _includeGroupCustomContactDirectoryInDirectory;
            set
            {
                IncludeGroupCustomContactDirectoryInDirectorySpecified = true;
                _includeGroupCustomContactDirectoryInDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeGroupCustomContactDirectoryInDirectorySpecified { get; set; }

        protected string _groupCustomContactDirectory;

        [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ff29a940e42c5c9737f7438c4e6eea9d:148")]
        [MinLength(1)]
        [MaxLength(40)]
        public string GroupCustomContactDirectory
        {
            get => _groupCustomContactDirectory;
            set
            {
                GroupCustomContactDirectorySpecified = true;
                _groupCustomContactDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool GroupCustomContactDirectorySpecified { get; set; }

    }
}
